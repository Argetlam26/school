
// Caesar cipher

while (true)
{
    Console.WriteLine("Press E to ENCODE or D to DECODE");
    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
    if (keyPressed.Key == ConsoleKey.E)
    {
        
        // Defining variables
        Console.WriteLine("Enter your message you wish to encode (only letters, a-z and A-Z):");
        string userInput = Console.ReadLine();
        
        bool stupidUser;
        int moveCountInt;
        string moveCountStr;
        string alphabetLower = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
        string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";

        // Converting number (cipher key)
        do
        {
            Console.WriteLine("Enter key number (1-25):");
            moveCountStr = Console.ReadLine();
            stupidUser = int.TryParse(moveCountStr, out moveCountInt);
            if (!stupidUser || moveCountInt < 1 || moveCountInt > 25)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 25.");
            }
        } while (!stupidUser || moveCountInt < 1 || moveCountInt > 25);

        List<char> cipheredText = new List<char>();

        // Putting the encrypted text into a list of characters
        for (int i = 0; i < userInput.Length; i++)
        {
            for (int j = 0; j < alphabetLower.Length; j++)
            {
                if (userInput[i] == alphabetLower[j])
                {
                    cipheredText.Add(alphabetLower[j + moveCountInt]);
                    break;
                }
                else
                {
                    if (userInput[i] == alphabetUpper[j])
                    {
                        cipheredText.Add(alphabetLower[j + moveCountInt]);
                        break;
                    }
                }
            }
        }

        // Printing encrypted text (list)
        Console.WriteLine("Your encrypted text:");
        for (int k = 0; k < cipheredText.Count; k++)
        {
            Console.Write(cipheredText[k]);
        }

        Console.WriteLine("\n\nPress Enter if you wish to exit program.");
    }

    if (keyPressed.Key == ConsoleKey.D)
    {
        
        // Defining variables
        Console.WriteLine("Enter your message you wish to decode:");
        bool stupidUser;
        bool allOptions = false;
        int moveCountInt;
        string userInput = Console.ReadLine();
        string moveCountStr;
        string alphabetLower = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
        string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        // Converting number (cipher key)
        do
        {
            Console.WriteLine("Enter key number 1-25 (leave empty and press Enter if you don't know):");
            moveCountStr = Console.ReadLine();
            stupidUser = int.TryParse(moveCountStr, out moveCountInt);
            if (moveCountStr == "")
            {
                allOptions = true;
                break;
            }
            if (!stupidUser || moveCountInt < 1 || moveCountInt > 25)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 25.");
            }
        } while (!stupidUser || moveCountInt < 1 || moveCountInt > 25);

        List<char> cipheredText = new List<char>();
        
        // If user doesn't know cipher key
        if (allOptions)
        {
            for (int m = 1; m < 26; m++)
            {
                for (int l = 0; l < userInput.Length; l++)
                {
                    for (int o = 0; o < alphabetLower.Length; o++)
                    {
                        if (userInput[l] == alphabetLower[o])
                        {
                            cipheredText.Add(alphabetLower[o - m + 26]);
                            break;
                        }
                        else
                        {
                            if (userInput[l] == alphabetUpper[o])
                            {
                                cipheredText.Add(alphabetLower[o - m + 26]);
                                break;
                            }
                        }
                    }
                }
            }

            // Printing every single option
            Console.WriteLine("All options for the input given:");
            for (int n = 0; n < 25; n++)
            {
                Console.Write("\n" + (n + 1) + ") ");
                for (int p = 0; p < userInput.Length; p++)
                {
                    Console.Write(cipheredText[n * userInput.Length + p]);
                }
            }
            Console.WriteLine("\n\nPress Enter if you wish to exit program.");
        }
        
        // Moving the letters in the opposite direction
        else
        {
            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = 0; j < alphabetLower.Length; j++)
                {
                    if (userInput[i] == alphabetLower[j])
                    {
                        cipheredText.Add(alphabetLower[j - moveCountInt + 26]);
                        break;
                    }
                    else
                    {
                        if (userInput[i] == alphabetUpper[j])
                        {
                            cipheredText.Add(alphabetLower[j - moveCountInt + 26]);
                            break;
                        }
                    }
                }
            }
            
            // Printing decrypted text
            Console.WriteLine("Your decrypted text:");
            for (int k = 0; k < cipheredText.Count; k++)
            {
                Console.Write(cipheredText[k]);
            }

            Console.WriteLine("\n\nPress Enter if you wish to exit program.");
        }
    }

    // Exit program
    if (keyPressed.Key == ConsoleKey.Enter)
    {
        Environment.Exit(0);
    }
}
