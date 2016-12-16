using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenerics
{
    class User
     { 
         public string Name { get; set; } 
         public int AgeInYears { get; set; } 
 
 
        public override string ToString()
         { 
             return Name; 
         } 
     } 

    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();

            var users = new LinkedList<User>();
                       var hans = new User
                       {
                           Name = "Hans",
                           AgeInYears = 30
                       };
                            users.addToHead(hans);
            Console.WriteLine("default: " + users.ToString());
            Console.WriteLine("custom: " + users.ToString(FormatUser));
            string userAges = users.ToString(u => u.AgeInYears.ToString());
            Console.WriteLine("age only: " + userAges);


            var newPerson = new List<Person>() {
           
                
            };
            
            newPerson.FilterOut(p => p.getName == "");




            Console.ReadKey();




        }

        static string FormatUser(User user)
         { 
             return user.Name + " (" + user.AgeInYears + ")"; 
         }

}




    
}
