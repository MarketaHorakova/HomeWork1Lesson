using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork1Lesson
{
    internal class Program
    {
        //        Zadání
        //Vytvoř pole typu int s těmito hodnotami {3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4,-2}. Pro kontrolu si obsah pole vypiš.
        //Vyhledej záporná čísla a změň je na kladné číslo, zároveň vyhledej nuly a ke každé přičti hodnotu jejího indexu. Výsledné pole si vypiš.
        //Vyhledej největší číslo v poli a vypiš ho.
        //Seřaď prvky v poli od nejmenšího po největší. Můžeš například využít toho, že už umíš najít největší číslo v poli. Prosím, nepoužívej už hotovou funkci na sortování,
        //jde o to, aby sis takovou funkci zkusila napsat sama.
        static void Main(string[] args)
        {
        //Set array   
        int[] arrayOfNumbers=new int[] { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };

        // Output of array on console
        Console.WriteLine("Here is original array:");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write($"{arrayOfNumbers[i]} ");
        }

        //Change negative and zero values
        Console.WriteLine("\nHere is positive array:");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == 0)
            {
                arrayOfNumbers[i] = i;
            }
            else if (arrayOfNumbers[i] < 0)
            {
                arrayOfNumbers[i] = Math.Abs(arrayOfNumbers[i]);
            }
            Console.Write($"{arrayOfNumbers[i]} ");
        }


        //Maximunm and minimum
        int maxValue = arrayOfNumbers.Max();
        int minValue = arrayOfNumbers.Min();
          
        Console.WriteLine($"\nMaximal value of your array is {maxValue} and minimal value is {minValue}.");

        //Sort array
        int [] sortedArray = new int[arrayOfNumbers.Length];

        int[] sortingArray = arrayOfNumbers;
       
        int switchNumber;

        for (int i = 0; i < sortingArray.Length; i++)
        {
        //cycle for comparison - only 11!
            for (int j = sortingArray.Length; j > 1; j--)
            {
                if ((sortingArray[j-2]) > (sortingArray[j-1]))
                {
                    switchNumber = sortingArray[j-2];
                    sortingArray[j - 2] = sortingArray[j - 1];
                    sortingArray[j - 1] = switchNumber;
                }
            }

        }
                
        //Sort array console output
        Console.WriteLine("\nMy sorting result:");
        for (int i = 0; i < sortedArray.Length; i++)
        {
           Console.Write($"{sortingArray[i]} ");
        }
        //Sort array CECK
        Console.WriteLine("\nSorting chceck:");
        Array.Sort(arrayOfNumbers);
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write($"{arrayOfNumbers[i]} ");
        }

        Console.ReadLine();
        }
               

    }
}