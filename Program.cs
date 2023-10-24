using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Jake jsou souradnice usecky?");
        Console.Write("x1: ");
        string s = Console.ReadLine();
        Console.Write("y1: ");
        string z = Console.ReadLine();
        Console.Write("x2: ");
        string p = Console.ReadLine();
        Console.Write("y2: ");
        string q = Console.ReadLine();
        double x1 = double.Parse(s);
        double y1 = double.Parse(z);
        double x2 = double.Parse(p);
        double y2 = double.Parse(q);

        double vzdalenostX = x2 - x1;
        double vzdalenostY = y2 - y1;

        double pyth = vzdalenostX * vzdalenostX + vzdalenostY * vzdalenostY;
        double usecka = Math.Sqrt(pyth);

        Console.WriteLine("Delka usecky je: " + usecka);

        double stredX = x2 - vzdalenostX / 2;
        double stredY = y2 - vzdalenostY / 2;

        double uhelR = Math.Atan(vzdalenostY / vzdalenostX);
        double uhel = uhelR * (180 / Math.PI);

        Console.WriteLine("Uhel je: " + uhel + "°");
        Console.WriteLine("Souradnice stredu usecky jsou: (" + stredX + "x, " + stredY + "y)");



    }
}