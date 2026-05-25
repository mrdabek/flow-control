namespace BioBioApp;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        // I set bool variable to define if program is runnnign then while loop to check if this condition is true. 
        
        while (programRunning)
        {
            Console.WriteLine();
            Console.WriteLine("=== HUVUDMENY ===");
            Console.WriteLine();
            Console.WriteLine("Skriv en siffra för att välja funktion.");
            Console.WriteLine("1 - Typ av billjet - Ungdom, Standard, Pensionär. Ange ålder så väljer vi rätt alternativ.");
            Console.WriteLine("2 - Gruppbilljet - Ange ålder och antal personer så räknar vi.");
            Console.WriteLine("3 - ");
            Console.WriteLine();
            Console.WriteLine("0 - Avsluta programmet");
            Console.WriteLine();

            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    Console.WriteLine("Programmet avslutas...");
                    programRunning = false;
                    break;

                case "1":
                    Console.WriteLine("Ange din ålder: ");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 5 || age > 100)
                    {
                        Console.WriteLine("Fri entré");
                    }
                    else if(age < 20) 
                    { 
                        Console.WriteLine("Ungdomspris: 80kr"); 
                    }
                    else if (age > 64)
                    { 
                        Console.WriteLine("Pensionärspris: 90kr");
                    }
                    else
                    {
                        Console.WriteLine("Standardpris: 120kr");
                    }
                    break;
                
                case "2":
                    Console.WriteLine("Gruppbilljet: Ange antal personer");
                    int peopleAmount = int.Parse(Console.ReadLine());
                    
                    break;


                default:
                    Console.WriteLine("Felaktig input.");
                    break;
            }
        }    
    }
}