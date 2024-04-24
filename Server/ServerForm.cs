using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Klient.Models;
using Server.Models;

namespace Server
{
    public partial class ServerForm : Form
    {
        private HttpListener listener;

        public ServerForm()
        {
            InitializeComponent();
            listener = new HttpListener();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:9001/";
            listener.Prefixes.Add(url);
            listener.Start();
           textBox1.Text =" Сервер запущено. Очікування запитів...";
            Task.Run(() => StartListening());
        }

        private async Task StartListening()
        {
            while (true)
            {
                HttpListenerContext context = await listener.GetContextAsync();

                string responseString = "";
                if (context.Request.HttpMethod == "POST")
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(context.Request.InputStream))
                        {
                            string requestBody = await reader.ReadToEndAsync();
                            var json = JObject.Parse(requestBody);
                            var header = json["Header"].ToString();
                            var user = JsonConvert.DeserializeObject<User>(requestBody);
                            responseString = await ProcessRequest(user, header);
                        }
                    }
                    catch (Exception ex)
                    {
                        textBox1.Text = ex.Message;
                        MessageBox.Show($"{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Непідтримуваний HTTP метод.");
                }

                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.Close();
            }
        }

        private async Task<string> ProcessRequest(User user, string header)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        await connection.OpenAsync();
                    }

                    if (connection.State == ConnectionState.Open)
                    {
                        switch (header)
                        {
                        


                            case "GibMirFrage":
                                string selectedThema = user.Login;
                              //  MessageBox.Show(user.Login);
                                if (string.IsNullOrEmpty(selectedThema))
                                {
                                    return "Thema is null or empty";
                                }

                                string selectQuery = "SELECT TOP 3 * FROM TestFragen WHERE Thema = @Thema ORDER BY NEWID()";
                                List<Frage> fragenList = new List<Frage>();

                                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                                {
                                    command.Parameters.Add("@Thema", System.Data.SqlDbType.NVarChar).Value = selectedThema;

                                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                                    {
                                        while (reader.Read())
                                        {
                                            Frage frage = new Frage
                                            {
                                                Id = reader.GetInt32(0),
                                                Thema = reader.GetString(1),
                                                Frage_ = reader.GetString(2),
                                                A1 = reader.GetString(3),
                                                A2 = reader.GetString(4),
                                                A3 = reader.IsDBNull(5) ? null : reader.GetString(5),
                                                WieVielFragen = reader.GetInt32(6),
                                                AntwortCode = reader.GetInt32(7)
                                            };

                                            fragenList.Add(frage);
                                        }
                                    }
                                }

                                return JsonConvert.SerializeObject(fragenList);

                            case "ListOfThema":
                                string themaQuery = "SELECT DISTINCT Thema FROM TestFragen";
                                List<string> themaList = new List<string>();

                                using (SqlCommand command = new SqlCommand(themaQuery, connection))
                                {
                                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                                    {
                                        while (await reader.ReadAsync())
                                        {
                                            string thema = reader["Thema"].ToString();
                                            themaList.Add(thema);
                                        }
                                    }
                                }

                                return JsonConvert.SerializeObject(themaList);

                            case "AUTH":
                                string authQuery = "SELECT Id FROM UsersTable WHERE Login = @Login AND Passwort = @Passwort";
                                using (SqlCommand authCommand = new SqlCommand(authQuery, connection))
                                {
                                    authCommand.Parameters.Add("@Login", SqlDbType.NVarChar).Value = user.Login ?? (object)DBNull.Value;
                                    authCommand.Parameters.Add("@Passwort", SqlDbType.NVarChar).Value = user.Passwort ?? (object)DBNull.Value;

                                    using (SqlDataReader reader = await authCommand.ExecuteReaderAsync())
                                    {
                                        if (reader.HasRows && reader.Read())
                                        {
                                            int userId = reader.GetInt32(reader.GetOrdinal("Id"));
                                           // MessageBox.Show($"Користувач {user.Login} автентифікований. Id: {userId}");


                                            // Додайте Id до відповіді
                                            var responseObj = new { Message = "Автентифікація успішна.", UserId = userId };
                                            string jsonResponse = JsonConvert.SerializeObject(responseObj);

                                            return jsonResponse;
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Помилка автентифікації для {user.Login}.");
                                            return "Невірний логін або пароль.";
                                        }
                                    }
                                }

                             
                            case "REGISTER":
                                string registerQuery = "INSERT INTO UsersTable (Login, Passwort) VALUES (@Login, @Passwort)";
                                using (SqlCommand registerCommand = new SqlCommand(registerQuery, connection))
                                {
                                    registerCommand.Parameters.Add("@Login", SqlDbType.NVarChar).Value = user.Login ?? (object)DBNull.Value;
                                    registerCommand.Parameters.Add("@Passwort", SqlDbType.NVarChar).Value = user.Passwort ?? (object)DBNull.Value;
                                    MessageBox.Show(user.Passwort);
                                    int result = await registerCommand.ExecuteNonQueryAsync();

                                    if (result > 0)
                                    {
                                      //  MessageBox.Show($"Дані для {user.Login} {user.Passwort} успішно вставлені.");
                                        return "Реєстрація успішна.";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Помилка реєстрації.");
                                        return "Помилка реєстрації.";
                                    }
                                }



                            default:
                                MessageBox.Show($"Невідомий хедер: {header}");
                                return "Невідомий хедер.";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося підключитися до бази даних.");
                        return "Не вдалося підключитися до бази даних.";
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    textBox1.Text = $"Помилка: {ex.Message}";
                });
                //MessageBox.Show($"Помилка: {ex.Message}");
                return $"Помилка: {ex.Message}";
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
