using System;
using System.Collections.Generic;

namespace whatever
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating obj of class customer
            customer customer1 = new customer()
            {   //setting the properties
                ID = 1,
                name = "Rohan",
                age = 24,
                salary = 23000
            };

            customer customer2 = new customer();
                 //setting properties in another way
                customer2.ID = 2;
                customer2.name = "Sadiq";
                customer2.age = 26;
                customer2.salary = 46000;

            //creating dictionary 
            Dictionary<int, customer> customerDictionary = new Dictionary<int, customer>();

            //adding both customers in dictionary
            customerDictionary.Add(customer1.ID, customer1);
            customerDictionary.Add(customer2.ID, customer2);

            //retrieving the info of customer having ID 1
            // customer customer01 = customerDictionary[1];

            //printing the info
            //Console.WriteLine("Name: {0} \nID: {1} \nAge: {2} \nSalary: {3}",customer01.name,customer01.ID,customer01.age,customer01.salary);




            //looping thru all the customers in dictionary
            foreach (KeyValuePair<int, customer> customers in customerDictionary)
            {
                customer cust = customers.Value;
                Console.WriteLine("Key: {0} \nName: {1} \nAge: {2} \nSalary: {3}", customers.Key, cust.name, cust.age, cust.salary);
                Console.WriteLine("-------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }

    class customer
    {           //class customer has these 4 properties.
        public int ID
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public int salary
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }
    }
}
