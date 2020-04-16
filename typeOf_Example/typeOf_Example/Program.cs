using System;
//To use MemberInfo data type we should declare the Reflection namespace.
using System.Reflection;

namespace typeOf_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string brand = "Boeing";
            string model = "777-200";
            int releaseYear = 1999;
            bool stillInService = true;
            Aircraft ac = new Aircraft(brand, model, releaseYear, stillInService);

            //First let's a take a look at user defined class properties
            //and its members type properties.
            //Here we declared a class named Aircraft and we are going to 
            Console.WriteLine("Aircraft class and members properties: ");
            Console.WriteLine("Aircraft is a " + ac.GetType());
            Console.WriteLine("Aircraft Member Example : ");
            Console.WriteLine("-Brand variable is a " + ac.Brand.GetType());
            Console.WriteLine("-Brand variables FullName is " + ac.Brand.GetType().FullName);
            Console.WriteLine("-Brand variables Namespace is " + ac.Brand.GetType().Namespace);

            Console.WriteLine(Environment.NewLine + "User Defined class Methods");
            //First we need to declare a MemberInfo array and load this array with class properties.
            MemberInfo[] ac_methods = ac.GetType().GetMethods();
            //Then we print all members with a for loop.
            for (int i = 0; i < ac_methods.Length; i++)
            {
                Console.WriteLine("--" + ac_methods[i].Name + " is a "+ ac_methods[i].MemberType);
            }
            
            //Here we see the usage of typeof with typeof we can check the type of a variable and 
            //we can make some operations if the related type is specified.
            Console.WriteLine(Environment.NewLine + "User Defined class properties");

            //Here first we declare a Type variable and we set it as type properties.
            //Then we use a foreach to print all of them first.
            Type ac_type = ac.GetType();
            foreach (var s in ac_type.GetProperties())
            {
                Console.WriteLine(s.Name + " " + s.PropertyType );
            }

            //Also we can filter the types of the class.
            Console.WriteLine(Environment.NewLine + "only string type Defined class properties");
            //And we will write here only strings type of the properties.
            foreach (var item in ac_type.GetProperties())
            {
                if (item.PropertyType == typeof(string))
                {
                    Console.WriteLine(item.Name + " " + item.PropertyType);
                }
            }

            Console.ReadLine();
        }
    }
}
