using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdProject
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var param in args)
            {
                if (param.Contains("?"))
                {
                    Console.WriteLine("programmet modtager en fil som input parameter");
                }
                //læser en fil fra OS udpeget
            }
            //jeg antager at argument[0] indeholder stien til datafilen
            List<string> UserList = new List<string>();

            try
            {
                using (StreamReader sr = File.OpenText(args[0]))
                {
                    string users = "";

                    while ((users = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(s);
                        UserList.Add(users);
                    }
                    foreach (var brugere in UserList)
                    {
                        Console.WriteLine(brugere);
                    }
                }
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error : " + Error.Message);
                //throw;
            }
            Console.Read();
        }
    }
}

