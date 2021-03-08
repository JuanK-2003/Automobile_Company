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
    public partial class Form3 : Form
    {
        List<Data> Rental = new List<Data>();
        string rentalFile = "Rental.txt";
        public Form3()
        {
            InitializeComponent();
            textNIT.Focus();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        public void writeRent()
        {
            List<Dictionary<string, string>> rental = new List<Dictionary<string, string>>();
            foreach (var rentals in Rental)
            {
                var temp = new Dictionary<string, string>();
                temp.Add("NIT", rentals.NIT1);
                temp.Add("\nLicense plate", rentals.LicensePlate);
                temp.Add("\nRental date", rentals.RentalDate.ToString());
                temp.Add("\nReturn date", rentals.ReturnDate.ToString());
                temp.Add("\nKilometers traveled", rentals.KilometersTraveled.ToString());
                rental.Add(temp);
            }
            string json = JsonConvert.SerializeObject(rental);
            using (StreamWriter sr = new StreamWriter(rentalFile))
            {
                sr.Write(json);
            }
        }
 
        public void showData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Rental;
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Add data
            Data temp = new Data();
            temp.NIT1 = textNIT.Text;
            temp.LicensePlate = textLicensePlate.Text;
            temp.RentalDate = calendarRental.SelectionStart;
            temp.ReturnDate = calendarReturn.SelectionStart;
            temp.Price = double.Parse(textKilometers.Text);
            temp.calculatePrice();
            Rental.Add(temp);
            //===============================================
            textNIT.Text = "";
            textLicensePlate.Text = "";
            textKilometers.Text = "";
            //===============================================
            showData();
        }
    }
}
