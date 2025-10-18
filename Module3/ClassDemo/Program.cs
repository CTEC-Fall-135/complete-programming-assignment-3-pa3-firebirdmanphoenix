/*
Author: Phoenix Vu
Date: 10/18/2025
Assignment: PA3
*/


namespace ClassDemo
{
    class Student
    { 
        //Fields
        private string name;
        private string address;
        private int ID { get; set; }

        //Method getter and setter
        public string GetName()
        {
            return name;
        }

        public void SetName(string x)
        {
            name = x;
        }

        //Property getter and setter
        public string SetAddress
        {
            get { return address; }
            set { address = value; }
        }

        //Constructors

        public Student() : this("John Doe", "308 Negra Arroyo Lane", 00000000) {}
        public Student(string name) : this(name, "308 Negra Arroyo Lane", 00000000) {}

        //Primary Constructor
        public Student(string name, string address, int ID) 
        {
            this.name = name;
            this.address = address;
            this.ID = ID;
        }

        //PrintState
        public void PrintState()
        {
            Console.WriteLine($"Name: {name}, Address: {address}, ID: {ID}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Student student1 = new Student("Arthur Morgan", "1984 Smth Street", 12345678);
            student1.PrintState();

            Student student2 = new Student("John Marston");
            student2.PrintState();

            Student student3 = new Student();
            student3.PrintState();

        }
    }
    
}
