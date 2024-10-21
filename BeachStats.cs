using System.IO;
using System.Reflection;

namespace BeachStats
{
    class Program
    {
        public static void VytvorBox(string s)
        {
            Console.WriteLine();
            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine(s);
            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        
        public static void Main(string[] args)
        {
            string welcome = "Vitejte v aplikaci BeachStats!";
            for (int i = 0; i < welcome.Length; i++)
            {
                Console.Write(welcome[i]);
                Thread.Sleep(100);
            }
            VytvorBox("napište “p” pro přihlášení nebo “r” pro registraci\nstiskněte ENTER pro potvrzení");
            
            while (true)
            {
                string logOrReg = Console.ReadLine();
                
                if (logOrReg == "r")
                {
                    // Registrace
                    break;
                }
                if (logOrReg == "p")
                {
                    // Prihlaseni
                    break;
                }

                VytvorBox("Nebylo vlozeno \"r\" nebo \"p\". Zkuste znovu:");
            }
            
            
            /*
            Console.WriteLine("Registrace nebo Prihlaseni");
            if (Console.ReadLine() == "r")
            {
                Console.WriteLine("What should we call you?");
                string username = Console.ReadLine();
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + username);
                Console.WriteLine("User successfully created!");
            }
            else
            {
                Console.WriteLine("Enter your username:");
                string username = Console.ReadLine();
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\" + username))
                {
                    Console.WriteLine("Successfully logged in!");
                }
                else
                {
                    Console.WriteLine("User does not exist.");
                }
            }
            */


            /*
            string dataToSave = "Imagine if this worked?";
            string username = Console.ReadLine();
            string filePath = username + ".txt";

            File.WriteAllText(filePath, dataToSave);

            string filePath = "testFile.txt";
            string data = File.ReadAllText(filePath);
            Console.WriteLine(data);

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\directory");
            */
        }
    }
}
