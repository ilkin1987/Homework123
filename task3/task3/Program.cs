using System;

namespace task3
{
    class Program
    {
        private static object item;

        static void Main(string[] args)
        {
            Employe employe1 = new Employe
            {
                FullName = "Ilham Rzayev",
                Position = "Muhasib",
                Salary = 600
            };

            Employe employe2 = new Employe
            {
                FullName = "Ramin Zeynalov",
                Position = "Direktor",
                Salary = 1500
            };

            Employe employe3 = new Employe
            {
                FullName = "Zakir Eliyev",
                Position = "Surucu",
                Salary = 400
            };


            Company company = new Company();
            company.Name = "AZ Steel MMC";
            company.Limit = 4;
            company.AddEmoployee(employe1);
            company.AddEmoployee(employe2);
            company.AddEmoployee(employe3);
            {
                Console.WriteLine($"{item.FullName} {item.No}");
            }
        }
    }
}
           
           
                
                   
            

        
    
