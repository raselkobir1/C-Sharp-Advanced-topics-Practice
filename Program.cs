using C_Sharp_Practice.ExtensionMethods;
using C_Sharp_Practice.Reflection;
using System;

namespace MyConsoleApp
{
    class Program
    {
        public delegate int CalculatorHandler(int x, int y);
        static void Main(string[] args)
        {
            // Code for the console application
            //int sum = calculatorHandler.Invoke(10, 20);

            //Console.WriteLine("Please enter two int number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //CalculatorHandler addMethod = Add;
            //DelegateMethodsCaller(addMethod,num1, num2);

            //CalculatorHandler subMethod = Sub;
            //DelegateMethodsCaller(subMethod, num1, num2);

            // Func delegate:
            //Func<int, int, int> CalculatorHandlar = Add;

            //Func<int, int, int> CalculatorHandlar = (int x, int y)=> x + y;

            //Func<int, int> CalculatorHandlar = x => x;
            //int res = CalculatorHandlar.Invoke(10);
            //Console.WriteLine("Result is :" +res);    

            //Action<int, int>ActionDelegateEx = (a,b) => Console.WriteLine( a + b);
            //ActionDelegateEx.Invoke(20, 30); 

            //List<string> names = new List<string>();
            //names.Add("Md Rasel");
            //names.Add("Kabir sing");
            //names.Add("Md Jamal");

            //Predicate<string> predicate = MuslimNameChecks; 
            ////var result = names.FindAll(predicate);
            //var result = names.FindAll(x=> x.Contains("Md"));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //------------Extension methods practice-------------------
            //Person person = new Person();
            //person.Id = 90070;
            //person.Name = "Rasel";
            //person.Details = "Software engineer at US Bangla group";
            //var details = person.GetPersonsInfo();
            //Console.WriteLine(details); 
            //Console.ReadKey();  

            //-------------Reflection practice-------------
            var typeForClass = new TestReflection("Kabir");
            Type StudentNametype = typeForClass.GetType();
            Console.WriteLine("Student name type : "+StudentNametype);
            Console.WriteLine("Student name type : "+StudentNametype.Assembly);
             var list =StudentNametype.GetMethods();
            foreach (var item in list)
            {
                Console.WriteLine("method name : " + item);

            }

        }

        static bool MuslimNameChecks(string name)
        {
            if (name.Contains("Md"))
            {
                return true;    
            }
            return false;
        }
        static void DelegateMethodsCaller(CalculatorHandler handler, int num1, int num2)
        {
            int sum = handler.Invoke(num1, num2);
            Console.WriteLine($"The result is {sum}"); 
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y; 
        }
    }
}

   


