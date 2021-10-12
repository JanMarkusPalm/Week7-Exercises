using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

                 
            int ctr = 0;


            while(ctr < 3)
            {
                Console.WriteLine("Palun sisestage PIN");
                string PIN = Console.ReadLine();
                Console.WriteLine("Palun sisestage nimi");
                string username = Console.ReadLine();
                Console.WriteLine("Palun sisestage password");
                string password = Console.ReadLine();
            

                if (PIN.Length == 4)
                {
                    if (username != "abcd" || password != "1234" || PIN != "1234")
                    {
                        Console.WriteLine("Midagi läks valesti. Proovige uuesti.");
                        ctr++;
                    }
                    else if (username == "abcd" && password == "1234" && PIN == "1234")
                    {
                        Console.Write("\nThe password entered successfully!\n\n");
                        break;
                    }


                }
                else
                {

                    Console.WriteLine("Vale PIN. Proovi uuesti");
                    continue;
                }
                

                
            }






























        /*
        Console.WriteLine("Palun sisesta kasutajatunnus ja seejärel parool");
        string Kasutajatunnus = Console.ReadLine();
        string Kasutajaparool = Console.ReadLine();

        int loginAttempts = 0;
        Console.WriteLine("Enter username");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password");
        string password = Console.ReadLine();


        for (int i = 0; i < 3; i++)
        {

            if (username != "admin" || password != "1234")
                loginAttempts++;
            else
                break;
        }

        if (password.Length > 4)
        {
            Console.WriteLine("Vale PIN. Proovi uuesti.");
        }

        //Display the result
        if (loginAttempts > 2)
            Console.WriteLine("Login failure");
        else
            Console.WriteLine("Login successful");

        Console.ReadKey();









        if (Kasutajaparool.Length > 4)
        {
            Console.WriteLine("Vale PIN, proovi uuesti");
        }
        else if (Kasutajaparool.Length == 4)
        {
            if (Kasutajatunnus != "admin" || Kasutajaparool != "1234")
            {
                Console.WriteLine("Login failed, please try again.");
            }
            else if (Kasutajatunnus == "admin" || Kasutajaparool == "1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
        }



        else
        {
            Console.WriteLine("Something went wrong. Please try again.");
        }
        */
    }
    }
}
