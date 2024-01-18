using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_class_example
{
    using System;
    // define a generics class named Employee
    class Employee<T>
    {
        // define a generics method that displays the passed data  
        public void displayData(T data)
        {
            Console.WriteLine("The data passed is: " + data);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            
            Employee<string> employeeName = new Employee<string>();
                       
            employeeName.displayData("Jack");
                         
            Employee<int> employeeId = new Employee<int>();
           
            employeeId.displayData(123);
            Console.Read();



       // Example: Generics Method with Return Type


            Movie<string> movieName = new Movie<string>();
            Console.WriteLine("Generics Method returns: " + movieName.displayData("Inception"));



            // create an instance with data type int  
            Movie<int> movieRating = new Movie<int>();
            Console.WriteLine("Generics Method returns: " + movieRating.displayData(9));
            Console.Read();
            Console.Read();

        }
    }


    // define a generics class named Movie
    class Movie<T>
    {
        // define a generics method that returns T type value    
        public T displayData(T data)
        {
            return data;
        }
    }
}
