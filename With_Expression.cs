using System;

namespace InitOnly
{
    public record Company
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company obj1 = new Company { ID = 1, Name = "ABC", City = "Mumbai" };
            Console.WriteLine(obj1.ID.ToString() + " " + obj1.Name + " " + obj1.City);

            Company obj2 = obj1 with {  Name="XYZ", City = "Thane" };
            Console.WriteLine(obj2.ID.ToString()+" "+ obj2.Name+" "+ obj2.City);

            Console.ReadLine();
        }
    }
}
