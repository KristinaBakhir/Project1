using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Human
    {
        private const int V = 18;
        protected string _name;
        protected string _surname;
        protected int _age;
        protected Address _address;

        public Human()
        {
            this._name = "Christina";
            this._surname = "Bakhir";
            this._age = V;
            this._address = new Address();
        }
        public Human(string name, string surname, int age, Address address)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._address = address;
        }
        public void printInfo()
        {
            string text =
                "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age + "\n" +
                "Address: " + this._address + "\n";

            Console.WriteLine(text);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public object Adress { get; internal set; }
        public object Nation { get; internal set; }
    }
}


