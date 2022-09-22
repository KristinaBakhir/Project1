using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work;

namespace @class
{
    class Teacher : Human
    {
        private int salary;
        private string department;
        private List<Student> list;

        public Teacher() : base()
        {
            List1 = new List<Student>();
        }
        public Teacher(string name, string surname, int age, double height,
        double weight, bool habbits, Nation nation, Adress adress, int salary, string department) : base(name, surname,
                age, height, weight, habbits, nation, adress)
        {
            this.salary = salary;
            this.department = department;
            this.List1 = new List<Student>();
        }
        public void add(Student human)
        {
            List1.Add(human);
        }
        public void show()
        {
            for (int n = 0; n < List1.Count(); n++)
                List1[n].printInfo();
        }
        public override void printInfo()
        {
            string data =
               "Name: " + this._name + "\n" +
               "Surname: " + this._surname + "\n" +
               "Age: " + this._age.ToString() + "\n" +
               "Height: " + this._height.ToString() + "\n" +
               "Weight: " + this._weight.ToString() + "\n" +
               "Is Habbits: " + this._habbits.ToString() + "\n" +
               "Nation: " + this._nation.ToString() + "\n" +
               "Adress: " + this._adress.toString() + "\n" +
               "Salary: " + this.salary.ToString() + "\n" +
               "Money: " + this.department;
            Console.WriteLine(data);

        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public List<Student> List
        {
            get { return List1; }
            set { List1 = value; }
        }

        public List<Student> List1 { get => List2; set => List2 = value; }
        public List<Student> List2 { get => list; set => list = value; }
        public List<Student> List3 { get => list; set => list = value; }
    }

}
