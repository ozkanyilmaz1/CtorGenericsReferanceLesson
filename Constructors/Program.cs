using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.FirstName);
            Customer customer3 = new Customer();
            customer3.Id = 3;
            
        }
        
    }
    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            City = city;
        }
        //sıklıkla kullanılan bir yöntem.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
