class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta; //byter färg på texten

        //skapar variabler
        bool isValidCalculationSymbol;
        bool isValidSymbol = false;
        double tal1, tal2, svar;
        string userSymbol;
        string validInputs = "+-*/RUru";

        while (true) //startar loopen
        {
            Console.WriteLine("Vad är ditt första tal? Skriv ett positivt eller negativt tal");
            var userInput = Console.ReadLine();
            //checkar om användaren skrivit in en siffra
            while (!double.TryParse(userInput, out tal1))
            {
                Console.WriteLine("Skriv ett tal");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Välj ett av de matematiska tecken nedan och skriv ut det");
            Console.WriteLine("______________________");
            Console.WriteLine("| Addition       = + |");
            Console.WriteLine("| Subtraktion    = - |");
            Console.WriteLine("| Multiplikation = * |");
            Console.WriteLine("| Division       = / |");
            Console.WriteLine("| Roten ur       = R |");
            Console.WriteLine("| Upphöjt i      = U |");
            Console.WriteLine("----------------------");
            
            userSymbol = Console.ReadLine().ToUpper();
            isValidSymbol = false;

            while (!isValidSymbol) 
            {
                // Kollar om användaren bara skrivit in tillåtna tecken
                isValidSymbol = userSymbol.Length == 1 && !string.IsNullOrWhiteSpace(userSymbol) && validInputs.Contains(userSymbol.ToUpper());

                if (!isValidSymbol)
                {
                    Console.WriteLine("Invalid input. Skriv en giltig matematiskt tecken.");
                    userSymbol = Console.ReadLine().ToUpper();
                }
            }

            if (validInputs.Contains(userSymbol))
            {
                if (userSymbol == "R")
                {
                    svar = Math.Sqrt(tal1); //beräknar roten ur tal1
                    Console.WriteLine("Roten ur " + tal1 + " = " + svar);
                }
                else
                {
                    Console.WriteLine("Skriv ditt andra tal");
                    var userInput3 = Console.ReadLine();
                    //checkar om användaren skrivit in en siffra
                    while (!double.TryParse(userInput3, out tal2)) 
                    {
                        Console.WriteLine("Skriv ett tal");
                        userInput3 = Console.ReadLine();
                    }

                    switch (userSymbol)  
                    {
                        case "+":
                            svar = tal1 + tal2; //beräknar tal1 + tal2
                            Console.WriteLine(tal1 + "+" + tal2 + "=" + svar);
                            break;
                        case "-":
                            svar = tal1 - tal2; //beräknar tal1 - tal2
                            Console.WriteLine(tal1 + "-" + tal2 + "=" + svar);
                            break;
                        case "*":
                            svar = tal1 * tal2; //beräknar tal1 * tal2
                            Console.WriteLine(tal1 + "*" + tal2 + "=" + svar);
                            break;
                        case "/":
                            svar = tal1 / tal2; //beräknar tal1 / tal2
                            Console.WriteLine(tal1 + "/" + tal2 + "=" + svar);
                            break;
                        case "U":
                            svar = Math.Pow(tal1, tal2); //beräknar tal1 ^ tal2
                            Console.WriteLine(tal1 + "^" + tal2 + "=" + svar);
                            break;
                    }
                }
            }
            string newCalculationInput;
            while (true) //Loop
            {
                Console.WriteLine("______________________________");
                Console.WriteLine("| vill du göra ett nytt tal? |");
                Console.WriteLine("|     Yes (Y)     No (N)     |");
                Console.WriteLine("------------------------------");

                newCalculationInput = Console.ReadLine().ToUpper();

                if (newCalculationInput == "N") 
                {
                    break; //Lämnar loopen
                }
                else if (newCalculationInput == "Y")
                {
                    break; //lämnar loopen och börjar om den andra loopen 
                }

            }
            if(newCalculationInput == "N")
            {
                break; //Lämnar Loopen och avsultar programmet
            }
        }
    }
}