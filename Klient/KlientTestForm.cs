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
using System.Data.SqlClient;
using System.Configuration;
using Klient.Models;
using Server.Models;

namespace Klient
{
    public partial class KlientTestForm : Form
    {
        public string Login { get; set; }
        public int UserId { get; set; }
        private List<Frage> fragenList = new List<Frage>();
        SendRes sendRes = new SendRes();
        public KlientTestForm()
        {
            InitializeComponent();

        }

        private async void KlientTestForm_Load(object sender, EventArgs e)
        {
            LoginLabel.Text = Login;
           // MessageBox.Show($"UserId = {UserId}");
            TasteRedag.Visible = false;
            kkGroupFrageAntwort.Visible = false;
            kkTasteStartWeiter.Visible = false;
            
            try
            {

                object user = null;
                user = new { Header = "ListOfThema" };
                string jsonUser = JsonConvert.SerializeObject(user);
                // Відправка запиту до сервера
                using (HttpClient httpClient = new HttpClient())
                {
                    var content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync("http://127.0.0.1:9001/api/tests", content);
                   
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var themaList = JsonConvert.DeserializeObject<List<string>>(jsonResponse);

                        foreach (var thema in themaList)
                        {
                            listeDerTests.Items.Add(thema);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error while fetching data from server.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private async void listeDerTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedThema = listeDerTests.SelectedItem.ToString();
                kkTasteStartWeiter.Visible = true;
                kkTasteStartWeiter.Text = "СТАРТ";
                object user = new { Header = "GibMirFrage", Login = selectedThema };
                string jsonUser = JsonConvert.SerializeObject(user);

                // Відправка запиту до сервера
                using (HttpClient httpClient = new HttpClient())
                {
                    var content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync("http://127.0.0.1:9001/api/tests", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        fragenList = JsonConvert.DeserializeObject<List<Frage>>(jsonResponse);
                       
                        //foreach (var frage in fragenList)
                        //{
                        //    // Добавление frage в список
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Error while fetching data from server.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private int currentFrageIndex = 0;
        int tesAntwortCode = 0;
        int gutAntwort = 0;
        int richtigeAntwortCode = 0;
        bool start=false;
        private void kkTasteStartWeiter_Click(object sender, EventArgs e)
        {
            if (kkTasteStartWeiter.Text == "СТАРТ")
            { 
                kkGroupFrageAntwort.Visible = true;
                kkTasteStartWeiter.Text = "Далі";
                TestLoop();              
                return;
            }
            if(kkTasteStartWeiter.Text =="ВИХІД")
            {
             

            
            
            }

            tesAntwortCode = 0;
          
            if (checkBox1.Checked)
            {
                tesAntwortCode += 100;
            }
            else tesAntwortCode += 800;
            if (checkBox2.Checked)
            {
                tesAntwortCode += 10;
            }
            else tesAntwortCode += 80;
            if (checkBox3.Checked)
            {
                tesAntwortCode += 1;
            }
            else tesAntwortCode += 8;

        

            if (currentFrageIndex >= 0)
            {
                if (tesAntwortCode == richtigeAntwortCode)
                    gutAntwort++;
             // MessageBox.Show($"тест правильних відповідей {gutAntwort}\n Я = {tesAntwortCode} тест = {richtigeAntwortCode}\n {currentFrageIndex} ");
            } 
            currentFrageIndex++;
            if (currentFrageIndex == 0)
            { }
            else
                TestLoop();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }
        
        private async void TestLoop()
        {
           
            richtigeAntwortCode= 0;
            if (kkTasteStartWeiter.Text == "Далі")
            { 
            
            }


            // Проверяем, не вышли ли за пределы списка вопросов
            if (currentFrageIndex >= fragenList.Count)
            {
                listeDerTests.Visible = false;
                label1.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                MessageBox.Show($"{gutAntwort}");
                if (gutAntwort > 2)
                {
                    kkFrageFeld.Items.Clear();  
                    kkFrageFeld.Items.Add("ВИ ПРОЙШЛИ ТЕСТ!!!");
                    kkTasteStartWeiter.Text = "ВИХІД";
                    sendRes = new SendRes { Header = "ResTest", UserId = UserId, Login = Login, DateTime = DateTime.Now, ResYaNein = true };
                    string jsonSendRes = JsonConvert.SerializeObject(sendRes);

                    using (HttpClient httpClient = new HttpClient())
                    {
                        var content = new StringContent(jsonSendRes, Encoding.UTF8, "application/json");
                        var response = await httpClient.PostAsync("http://127.0.0.1:9001/api/results", content);

                        if (response.IsSuccessStatusCode)
                        {
                            // Обработка успешного ответа
                        }
                        else
                        {
                            MessageBox.Show("Error while sending data to server.");
                        }
                    }


                }
                else
                {
                    kkFrageFeld.Items.Clear();
                    kkFrageFeld.Items.Add("ВИ  НЕ  ПРОЙШЛИ ТЕСТ!!!");
                    kkTasteStartWeiter.Text = "ВИХІД";
                    sendRes.UserId = UserId;
                    sendRes.Login = Login;
                    sendRes.ResYaNein = false;
                }
                return;
            }
            else
            {
                var frage = fragenList[currentFrageIndex];

                kkFrageFeld.Items.Clear();
                kkFrageFeld.Items.Add(frage.Frage_);
                checkBox1.Text = frage.A1;
                checkBox2.Text = frage.A2;
                checkBox3.Text = frage.A3;
                richtigeAntwortCode = frage.AntwortCode;

                // Установка видимости третьего чекбокса в зависимости от количества ответов
                checkBox3.Visible = (frage.WieVielFragen != 2);
                //if (currentFrageIndex == 0)
                //{ }
                //else
                //{

                //}
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
