using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_repaso
{
    class Data
    {
        string NIT;
        string name;
        string direction;
        string licensePlate;
        string marca;
        int model;
        string color;
        double price;
        DateTime rentalDate;
        DateTime returnDate;
        double kilometersTraveled;

        public Data()
        {

        }

        public Data(string nIT, string name, string direction, string licensePlate, string marca, int model, string color, double price, DateTime rentalDate, DateTime returnDate, double kilometersTraveled)
        {
            NIT1 = nIT;
            this.Name = name;
            this.Direction = direction;
            this.LicensePlate = licensePlate;
            this.Marca = marca;
            this.Model = model;
            this.Color = color;
            this.Price = price;
            this.RentalDate = rentalDate;
            this.ReturnDate = returnDate;
            this.KilometersTraveled = kilometersTraveled;
            this.totalPrice = price * kilometersTraveled;
        }
        public double totalPrice { get; set; }
        public string NIT1 { get => NIT; set => NIT = value; }
        public string Name { get => name; set => name = value; }
        public string Direction { get => direction; set => direction = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }
        public DateTime RentalDate { get => rentalDate; set => rentalDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public double KilometersTraveled { get => kilometersTraveled; set => kilometersTraveled = value; }

        public void calculatePrice()
        {
            this.totalPrice = this.Price * this.KilometersTraveled;
        }
    }
}
