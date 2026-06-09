namespace BioBioApp;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        // I set bool variable to define if program is runing then while loop to check if this condition is true. 
        
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
                    HandleSingleTicket();
                    break;
                    
                
                case "2":
                    HandleGroupTicket();
                    break;
                
                default:
                    Console.WriteLine("Felaktig input.");
                    break;
            }
        }    
    }

    static void HandleSingleTicket()
    {
        Console.WriteLine("Ange din ålder: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age < 5 || age > 100)
            {
                // Console.WriteLine("Fri entré");
            }
            else switch (age)
            {
                case < 20:
                    Console.WriteLine("Ungdomspris: 80kr");
                    break;
                case > 64:
                    Console.WriteLine("Pensionärspris: 90kr");
                    break;
                default:
                    Console.WriteLine("Standardpris: 120kr");
                    break;
            }
                                            
        }
        else
        {
            Console.WriteLine("Ogiltig input");
        }
    }

    static void HandleGroupTicket()
    {
        Console.WriteLine("Gruppbilljet: Hur många är ni?");
        
        if (int.TryParse(Console.ReadLine(), out int peopleAmount))
        {
            int totalPrice = 0;
            for (int i = 1; i <= peopleAmount; i++)
            {
                Console.WriteLine($"Ange ålder för person {i}");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    totalPrice += GetTicketPrice(age);
                }
                else 
                { 
                    Console.WriteLine("Ogiltig input"); 
                } 
            }
            Console.WriteLine($"Antal personer: {peopleAmount}");
            Console.WriteLine($"Totalt pris: {totalPrice} kr");
        }
        else
        {
            Console.WriteLine("Ogiltig input");
        }
        
    }

    static int GetTicketPrice(int age)
    {
        if (age < 5 || age > 100)
            return 0;

        if (age < 20)
            return 80;
        
        if (age > 64)
            return 90;
        
        return 120;
    }
    
}