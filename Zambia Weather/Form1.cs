using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Zambia_Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            cities_combobox.TextChanged += Cities_combobox_TextChanged;
            UpdateWeathertimer.Tick += UpdateWeathertimer_Tick;
            CheckForInternetConnection();
            UpdateWeathertimer.Start();
        }

        private void UpdateWeathertimer_Tick(object sender, EventArgs e)
        {
            SetWeatherOnUI();
        }

        private void Cities_combobox_TextChanged(object sender, EventArgs e)
        {
            SetWeatherOnUI();
        }

        private void CheckForInternetConnection()
        {
            try
            {
                using(WebClient client = new WebClient())
                {
                    client.OpenRead("http://clients3.google.com/generate_204");
                }      
            }
            catch
            {
                MessageBox.Show("Failed to get weather update. Check your internet connection", "No Internet");
            }
        }

        private string[] GetCities()
        {
            string[] cities = {"Lusaka", "Ndola", "Livingstone", "Chipata", "Kitwe", "Kabwe", "Chingola", "Mufulira",
                "Kasama", "Luanshya", "Solwezi" };

            return cities;
        }

        private void PopulateComboBox()
        {
            foreach (string city in GetCities())
            {
                cities_combobox.Items.Add(city);
            }
        }

        private void SetWeatherOnUI()
        {
            WeatherReport weather = new WeatherReport();
            weather.RequestWeatherJson(cities_combobox.Text, "zm");
            weather.AssignData();
            mainTempLabel.Text = weather.MainTemp.ToString() + "ºC";
            minTempView.Text = weather.Temp_min.ToString() + "ºC";
            maxtempview_label.Text = weather.Temp_max.ToString() + "ºC";
        }

        
    }
}
