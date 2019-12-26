using System;
using System.Collections.Generic;
using System.Text;

namespace Address
{
    class Address
    {
        private int index;
        private string country;
        private string street;
        private int house;
        private string apartment;
        public int Index
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("index < 0");
                else
                    index = value;

            }
            get { return index; }
        }

        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        public int House
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("house < 0");
                else
                    house = value;
            }
            get { return house; }
        }
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }

        public void inputAdress()
        {
            Console.Write("index     -  ");
            Index = int.Parse(Console.ReadLine());
            Console.Write("country   -  ");
            Country = Console.ReadLine();
            Console.Write("street    -  ");
            Street = Console.ReadLine();
            Console.Write("house     -  ");
            House = int.Parse(Console.ReadLine());
            Console.Write("apartment -  ");
            Apartment = Console.ReadLine();
        }
        public void outputAdress()
        {
            Console.Write("index     -  " + index);
            Console.WriteLine();
            Console.Write("country   -  " + country);
            Console.WriteLine();
            Console.Write("street    -  " + street);
            Console.WriteLine();
            Console.Write("house     -  " + house);
            Console.WriteLine();
            Console.Write("apartment -  " + apartment);


        }
    }
}
