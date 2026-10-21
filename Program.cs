namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.
        
        Console.Title = "annee-bissextile";
       Console.WriteLine("Welcome to annee-bissextile");
       while (true)
       {
           
       
       Console.WriteLine("Please enter a year");
       int.TryParse(Console.ReadLine(), out int year);
       if ((year % 4 == 0) && (year % 100 != 0)
           || ((year % 400 == 0)))
        {
           Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
       }
       
       
       
       
       
       
       
       
       
          
       

    }
}