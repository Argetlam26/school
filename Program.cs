// Welcome screen
Console.WriteLine("|This is an app for your homework assignments|");
Console.Write("!!!YOU CAN ALWAYS CLICK");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(" H ");
Console.ForegroundColor = ConsoleColor.Black;
Console.Write("FOR");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(" \"HELP\" ");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("TO VIEW THE MANUAL!!!");

// Defining lists for parts of the assignmenst
List<string> names = new List<string>();
List<string> descriptions = new List<string>();
List<string> isItDone = new List<string>();
List<string> deadline = new List<string>();
List<string> priority = new List<string>();

string[] manual = {"press A to \"(A)dd new assignment\"", "press R to \"(R)emove an assignment\"", "press V to \"(V)iew current assignments\"", "press D to \"add (D)ate\"", "press M to \"(M)ark assignment as done/working-on/to-do\""};
int[] manualLengths = new int[manual.Length];
int[] assignmentLengths = new int[15];

// Calculating longest manual item ==> sizes of manual box
for (int i = 0; i < manual.Length; i++)
{
    manualLengths[i] = manual[i].Length;
}

int longestManualPart = manualLengths[0];

for (int i = 0; i < manualLengths.Length; i++)
{
    if (manualLengths[i] > longestManualPart)
    {
        longestManualPart = manualLengths[i];
    }
}

// Printing the manual (part of the welcome screen)
for (int j = 0; j < (longestManualPart - 2) / 2; j++)
{
    Console.Write("-");
}
Console.Write("MANUAL");
for (int j = 0; j < (longestManualPart - 2) / 2; j++)
{
    Console.Write("-");
}

// Small fix if longest manual part is odd
if (longestManualPart % 2 != 0)
{
    Console.Write("-");
}

Console.WriteLine();

for (int i = 0; i < manual.Length; i++)
{
    Console.Write("| " + manual[i]);
    for (int j = 0; j < longestManualPart - manualLengths[i]; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine(" |");
}

Console.Write("\r");

for (int j = 0; j < longestManualPart + 4; j++)
{
    Console.Write("-");
}
Console.WriteLine();

// Main loop that is the app it self
while (true)
{
    // View all assignments
    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
    if (keyPressed.Key == ConsoleKey.V)
    {
        // Calculating longest assignment ==> size of assignment box
        for (int i = 0; i < names.Count; i++)
        {
            assignmentLengths[i] = names[i].Length + descriptions[i].Length;
        }

        int longestAssignmentPart = assignmentLengths[0];

        for (int i = 0; i < names.Count; i++)
        {
            if (assignmentLengths[i] > longestAssignmentPart)
            {
                longestAssignmentPart = assignmentLengths[i];
            }
        }
        // Prints top side of the box
        for (int j = 0; j < (longestAssignmentPart - 4) / 2; j++)
        {
            Console.Write("-");
        }

        Console.Write("ASSIGNMENTS");
        for (int j = 0; j < (longestAssignmentPart - 4) / 2; j++)
        {
            Console.Write("-");
        }

        // Small fix if longest assignment length is odd
        if (longestAssignmentPart % 2 != 0)
        {
            Console.Write("-");
        }

        Console.WriteLine();
        
        // Prints the assignments + borders
        for (int i = 0; i < names.Count; i++)
        {
            Console.Write("| " + names[i] + " - " + descriptions[i]);
            for (int j = 0; j < longestAssignmentPart - assignmentLengths[i]; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(" |");
        }

        Console.Write("\r");

        // Prints the bottom side of the box
        for (int j = 0; j < longestAssignmentPart + 7; j++)
        {
            Console.Write("-");
        }

        Console.WriteLine();
    }   
    
    // Add deadline to an assignment
    if (keyPressed.Key == ConsoleKey.D)
    {
        Console.WriteLine("Enter ID of the assignment you want to add deadline to:");
        string strI = Console.ReadLine();
        int i = Int32.Parse(strI);
        Console.WriteLine("Enter the deadline in format DD/MM/YYYY");
        string assignmentDeadline = Console.ReadLine();
        deadline.Insert(i, assignmentDeadline);
    }   
    
    // Add an assignment
    if (keyPressed.Key == ConsoleKey.A)
    {
        // Limit maximum assignments to 15
        if (names.Count == 15)
        {
            Console.WriteLine("You reached assignment limit of 15. Delete an assignment if you wish to add a new one.");
        }
        else
        {
            Console.WriteLine("How is your new assignment called?");
            string newAssignment = Console.ReadLine();
            Console.WriteLine("You can now give it a closer description:");
            string newDescription = Console.ReadLine();
            Console.WriteLine("How important is this project? Scale from 1-5. 1 = Not important at all, 5 = Vitally important:");
            string newPriority = Console.ReadLine();
            Console.WriteLine("Assignment succesfully added! You can click V to (V)iew your assignments.");
            names.Insert(0,newAssignment);
            descriptions.Insert(0,newDescription);
            isItDone.Insert(0, "to-do");
            deadline.Insert(0, "no deadline");
            priority.Insert(0, newPriority);
        }
    }

    // Remove an assignment
    if (keyPressed.Key == ConsoleKey.R)
    {
        Console.WriteLine("Enter ID of the assignment you wish to remove:");
        string strI = Console.ReadLine();
        int i = Int32.Parse(strI);
        names.RemoveAt(i);
        descriptions.RemoveAt(i);
        Console.WriteLine("Successfully removed assignment " + i);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Be careful, as some of the assignment's IDs have changed. Press V to check new IDs");
        Console.ForegroundColor = ConsoleColor.Black;
    }

    // Mark assignments as done/working-on/to-do
    if (keyPressed.Key == ConsoleKey.M)
    {
        Console.WriteLine("Enter ID of the assignment you wish to mark as Done/Unfinished:");
        string strI = Console.ReadLine();
        int i = Int32.Parse(strI);
        Console.WriteLine("Press D to mark as (D)one, W for (W)orking on it and T for (T)o-do");
        ConsoleKeyInfo keyPressed2 = Console.ReadKey(true);
        if (keyPressed2.Key == ConsoleKey.D)
        {
            isItDone.RemoveAt(i);
            isItDone.Insert(i, "DONE");
            Console.WriteLine("Marked as done!");
        }
        if (keyPressed2.Key == ConsoleKey.W)
        {
            isItDone.RemoveAt(i);
            isItDone.Insert(i, "...");
            Console.WriteLine("Marked as currently working on!");
        }
        if (keyPressed2.Key == ConsoleKey.T)
        {
            isItDone.RemoveAt(i);
            isItDone.Insert(i, "X");
            Console.WriteLine("Marked as to-do!");
        }
    }

    // Prints the manual in case user forgets
    if (keyPressed.Key == ConsoleKey.H)
    {
        for (int j = 0; j < (longestManualPart - 2) / 2; j++)
        {
            Console.Write("-");
        }

        Console.Write("MANUAL");
        for (int j = 0; j < (longestManualPart - 2) / 2; j++)
        {
            Console.Write("-");
        }

        // Small fix if longest manual part is odd
        if (longestManualPart % 2 != 0)
        {
            Console.Write("-");
        }

        Console.WriteLine();

        for (int i = 0; i < manual.Length; i++)
        {
            Console.Write("| " + manual[i]);
            for (int j = 0; j < longestManualPart - manualLengths[i]; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(" |");
        }

        Console.Write("\r");

        for (int j = 0; j < longestManualPart + 4; j++)
        {
            Console.Write("-");
        }

        Console.WriteLine();
    }
}
