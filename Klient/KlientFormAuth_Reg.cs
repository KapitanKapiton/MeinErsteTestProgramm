using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Klient
{
    
    public partial class KlientFormAuth_Reg : Form
    {
        private string login;
        private string passwort;

        public KlientFormAuth_Reg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kkTasteEnterAdd.Text = "Реєстрація";
                LoginFeld.Text = "Введіть логін";
                PasswortFeld.Text = "Введіть пароль";
            }
            else
            {
                PasswortFeld.Text = "";
                LoginFeld.Text = "";
                kkTasteEnterAdd.Text = "Вхід";
            }

        }

        private void LoginFeld_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswortFeld_TextChanged(object sender, EventArgs e)
        {

        }

        private async void kkTasteEnterAdd_Click(object sender, EventArgs e)
        {
            login = LoginFeld.Text;
            passwort = PasswortFeld.Text;

            object user = null; // Задаємо user як object, щоб можна було встановити його в обох гілках if-else

            // Створення об'єкта User
            if (checkBox1.Checked)
            {
                user = new { Header = "REGISTER", Login = login, Passwort = passwort };
            }
            else
            {
                user = new { Header = "AUTH", Login = login, Passwort = passwort };
            }

            // Серіалізація об'єкта User в JSON
            string jsonUser = JsonConvert.SerializeObject(user);

            // Відправка JSON на сервер
            using (HttpClient httpClient = new HttpClient())
            {
                var content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://127.0.0.1:9001/api/users", content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var responseObj = JsonConvert.DeserializeObject<dynamic>(jsonResponse);

                   // MessageBox.Show(responseObj.Message);

                    if (responseObj.UserId != null)
                    {
                        int userId = responseObj.UserId;

                        KlientTestForm klientTestForm = new KlientTestForm();
                        klientTestForm.Login = LoginFeld.Text;
                        klientTestForm.UserId = responseObj.UserId;
                        this.Hide();
                        klientTestForm.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Клієнт Помилка під час надсилання даних на сервер.");
                }
            }
        }

        private void LoginFeld_MouseDown(object sender, MouseEventArgs e)
        {
            if(checkBox1.Checked)
            LoginFeld.Text = "";
        }

        private void PasswortFeld_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked)
                PasswortFeld.Text = "";
        }
    }
}
