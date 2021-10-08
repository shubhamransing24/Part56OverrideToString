using System;

namespace Part56OverrideToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("String conversion={0}",a.ToString());
            string s = Convert.ToString(a);
            Console.WriteLine(s);
            Customers c1 = new Customers
            {
                FirstName="Shubham",
                LastName="Ransing"

            };
            //this is the  problem issue it prints namespace name.class name thats why i need to override this method
            Console.WriteLine(c1.ToString());


 
    }
    }
    class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //here we  just change the defination of to string method now method is working like our requirement
        public override string ToString()
        {
            return LastName + " " + FirstName;
        }

    }
}
