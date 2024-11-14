namespace Vicerozmerne_Pole
{
    class Program
    {
        public static double[,] RandomArray(int m)
        {
            Random r = new Random();
            
            double[,] randomArr = new double[m,m];
            int plusOrMinus;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int randomNumber = r.Next();
                    if (randomNumber % 2 == 0)
                    {
                        plusOrMinus = 1;
                    }
                    else
                    {
                        plusOrMinus = -1;
                    }
                    randomArr[i, j] = Math.Round((r.NextDouble() * 10) * plusOrMinus, 1);
                }
            }

            return randomArr;
        }

        public static double[] Diagonal(double[,] randomArr, int m)
        {
            double[] diagonalArray = new double[m];
            for (int i = 0; i < m; i++)
            {
                diagonalArray[i] = randomArr[i, i];
            }

            return diagonalArray;
        }

        public static double[] SecondRow(double[,] randomArr, int m)
        {
            double[] secondRow = new double[m];
            for (int i = 0; i < m; i++)
            {
                secondRow[i] = randomArr[1, i];
            }

            return secondRow;
        }
        
        public static double[] SecondToLastRow(double[,] randomArr, int m)
        {
            double[] secondToLastRow = new double[m];
            for (int i = 0; i < m; i++)
            {
                secondToLastRow[i] = randomArr[m - 2, i];
            }

            return secondToLastRow;
        }
        
        public static double[] SecondToLastColumn(double[,] randomArr, int m)
        {
            double[] secondToLastColumn = new double[m];
            for (int i = 0; i < m; i++)
            {
                secondToLastColumn[i] = randomArr[i, m - 2];
            }

            return secondToLastColumn;
        }

        public static double[] SumOfColumns(double[,] randomArr, int m)
        {
            double[] sumOfColumns = new double[m];
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sumOfColumns[i] = sumOfColumns[i] + randomArr[j, i];
                }
                sumOfColumns[i] = Math.Round(sumOfColumns[i], 1);
            }

            return sumOfColumns;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int m = r.Next(1, 20);

            double[,] randomArr = RandomArray(m);
            double[] diagonalArray = Diagonal(randomArr, m);
            double[] secondRow = SecondRow(randomArr, m);
            double[] secondToLastRow = SecondToLastRow(randomArr, m);
            double[] secondToLastColumn = SecondToLastColumn(randomArr, m);
            double[] sumOfColumns = SumOfColumns(randomArr, m);
            
            for (int k = 0; k < m; k++)
            {
                for (int l = 0; l < m; l++)
                {
                    Console.Write(randomArr[k, l] + " ");
                }
                Console.Write("\n");
            }
            
            Console.WriteLine("DIAGONALA");
            Console.WriteLine("_______________________________________________");
            for (int n = 0; n < m; n++)
            {
                Console.Write(diagonalArray[n] + " ");
            }
            
            Console.WriteLine("\nDRUHY RADEK");
            Console.WriteLine("_______________________________________________");
            for (int o = 0; o < m; o++)
            {
                Console.Write(secondRow[o] + " ");
            }
            
            Console.WriteLine("\nPREDPOSLEDNI RADEK");
            Console.WriteLine("_______________________________________________");
            for (int p = 0; p < m; p++)
            {
                Console.Write(secondToLastRow[p] + " ");
            }
            
            Console.WriteLine("\nPREDPOSLEDNI SLOUPEC");
            Console.WriteLine("_______________________________________________");
            for (int q = 0; q < m; q++)
            {
                Console.Write(secondToLastColumn[q] + " ");
            }
            
            Console.WriteLine("\nSOUCET SLOUPCU");
            Console.WriteLine("_______________________________________________");
            for (int s = 0; s < m; s++)
            {
                Console.Write(sumOfColumns[s] + " ");
            }
        }
    }
}namespace Vicerozmerne_Pole
{
    class Program
    {
        public static double[,] RandomArray(int m)
        {
            Random r = new Random();
            
            double[,] randomArr = new double[m,m];
            int plusOrMinus;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int randomNumber = r.Next();
                    if (randomNumber % 2 == 0)
                    {
                        plusOrMinus = 1;
                    }
                    else
                    {
                        plusOrMinus = -1;
                    }
                    randomArr[i, j] = Math.Round((r.NextDouble() * 10) * plusOrMinus, 1);
                }
            }

            return randomArr;
        }

        public static double[] Diagonal(double[,] randomArr, int m)
        {
            double[] diagonalArray = new double[m];
            for (int i = 0; i < m; i++)
            {
                diagonalArray[i] = randomArr[i, i];
            }

            return diagonalArray;
        }

        public static double[] SecondRow(double[,] randomArr, int m)
        {
            double[] secondRow = new double[m];
            for (int i = 0; i < m; i++)
            {
                secondRow[i] = randomArr[1, i];
            }

            return secondRow;
        }
        
        public static double[] SecondToLastRow(double[,] randomArr, int m)
        {
            double[] secondToLastRow = new double[m];
            for (int i = 0; i < m; i++)
            {
                secondToLastRow[i] = randomArr[m - 2, i];
            }

            return secondToLastRow;
        }
        
        public static double[] SecondToLastColumn(double[,] randomArr, int m)
        {
            double[] secondToLastColumn = new double[m];
            for (int i = 0; i < m; i++)
            {
                secondToLastColumn[i] = randomArr[i, m - 2];
            }

            return secondToLastColumn;
        }

        public static double[] SumOfColumns(double[,] randomArr, int m)
        {
            double[] sumOfColumns = new double[m];
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sumOfColumns[i] = sumOfColumns[i] + randomArr[j, i];
                }
                sumOfColumns[i] = Math.Round(sumOfColumns[i], 1);
            }

            return sumOfColumns;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int m = r.Next(1, 20);

            double[,] randomArr = RandomArray(m);
            double[] diagonalArray = Diagonal(randomArr, m);
            double[] secondRow = SecondRow(randomArr, m);
            double[] secondToLastRow = SecondToLastRow(randomArr, m);
            double[] secondToLastColumn = SecondToLastColumn(randomArr, m);
            double[] sumOfColumns = SumOfColumns(randomArr, m);
            
            for (int k = 0; k < m; k++)
            {
                for (int l = 0; l < m; l++)
                {
                    Console.Write(randomArr[k, l] + " ");
                }
                Console.Write("\n");
            }
            
            Console.WriteLine("DIAGONALA");
            Console.WriteLine("_______________________________________________");
            for (int n = 0; n < m; n++)
            {
                Console.Write(diagonalArray[n] + " ");
            }
            
            Console.WriteLine("\nDRUHY RADEK");
            Console.WriteLine("_______________________________________________");
            for (int o = 0; o < m; o++)
            {
                Console.Write(secondRow[o] + " ");
            }
            
            Console.WriteLine("\nPREDPOSLEDNI RADEK");
            Console.WriteLine("_______________________________________________");
            for (int p = 0; p < m; p++)
            {
                Console.Write(secondToLastRow[p] + " ");
            }
            
            Console.WriteLine("\nPREDPOSLEDNI SLOUPEC");
            Console.WriteLine("_______________________________________________");
            for (int q = 0; q < m; q++)
            {
                Console.Write(secondToLastColumn[q] + " ");
            }
            
            Console.WriteLine("\nSOUCET SLOUPCU");
            Console.WriteLine("_______________________________________________");
            for (int s = 0; s < m; s++)
            {
                Console.Write(sumOfColumns[s] + " ");
            }
        }
    }
}
