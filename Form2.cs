using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_repaso
{
    public partial class Form2 : Form
    {
        List<Data> vehicle = new List<Data>();
        string vehiclesFiles = "Vehicles.txt";
        public Form2()
        {
            InitializeComponent();
            textLicensePlate.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        public void writeVehicles()
        {
            List<Dictionary<string, string>> Vehicles = new List<Dictionary<string, string>>();
            foreach (var vehicles in vehicle)
            {
                var temp = new Dictionary<string, string>();
                temp.Add("License plate", vehicles.LicensePlate);
                temp.Add("\nMarca", vehicles.Marca);
                temp.Add("\nModel", vehicles.Model.ToString());
                temp.Add("\nColor", vehicles.Color);
                temp.Add("\nPrice", vehicles.Price.ToString());
                Vehicles.Add(temp);
            }
            
            string json = JsonConvert.SerializeObject(Vehicles);
            using (StreamWriter sr = new StreamWriter(vehiclesFiles))
            {
                sr.Write(json);
            }
        }

        private void showData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vehicle;
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Add data
            Data temp = new Data();
            if(File.Exists(temp.LicensePlate))
            {
                MessageBox.Show("The car already exists!!");
            }
            else
            {
                temp.LicensePlate = textLicensePlate.Text;
                temp.Marca = textMarca.Text;
                temp.Model = int.Parse(textModel.Text);
                temp.Color = textColor.Text;
                temp.Price = double.Parse(textPrice.Text);
                temp.calculatePrice();
                vehicle.Add(temp);
            }
            //==========================================
            textLicensePlate.Text = "";
            textMarca.Text = "";
            textModel.Text = "";
            textColor.Text = "";
            textPrice.Text = "";
            //==========================================
            showData();
        }
    }
}
