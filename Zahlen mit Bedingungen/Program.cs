using System.Net.NetworkInformation;

namespace Zahlen_mit_Bedingungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;

            //source
            int[] numbers = new int[101];
            for (int i = 0; i < 101; i++)
            {
                numbers[i] = i;
            }

            //creating queries
            var greaterThen = from number in numbers
                              where number > userNumber
                              select number;

            var lessThen = from number in numbers
                           where number < userNumber
                           orderby number descending
                           select number;

            var even = from number in numbers
                       where number % 2 == 0
                       select number;

            var odd = from number in numbers
                      where number % 2 != 0
                      select number;

            var underHundretAfterAdding = from number in numbers
                                          where number + userNumber < 100
                                          select number;

            var aboveZeroAfterSubtracting = from number in numbers
                                            where number - userNumber > 0
                                            select number;

            //executing queries
            do
            {
                Console.WriteLine("Hallo, Was möchten Sie tun? (g)rösserAls, (k)leinerAls, ge(r)adeZahlen, (u)ngeradeZahlen, unterHundertNach(A)ddition, überNullNach(S)ubtraktion");
                ConsoleKeyInfo key = Console.ReadKey(true);
                char choice = key.KeyChar;
                Console.Clear();

                switch (choice)
                {
                    case 'g':
                        Console.Write("Grösser als welche Zahl? ");
                        userNumber = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("");
                        foreach (int number in greaterThen)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 'k':
                        Console.Write("Kleiner als welche Zahl? ");
                        userNumber = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("");
                        foreach (var number in lessThen)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 'r':
                        foreach (var number in even)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 'u':
                        foreach (var number in odd)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 'a':
                        Console.Write("Welche Zahl möchten Sie addieren? ");
                        userNumber = (Convert.ToInt16(Console.ReadLine()));
                        Console.WriteLine("");
                        foreach (var number in underHundretAfterAdding)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 'A':
                        Console.Write("Welche Zahl möchten Sie addieren? ");
                        userNumber = (Convert.ToInt16(Console.ReadLine()));
                        Console.WriteLine("");
                        foreach (var number in underHundretAfterAdding)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 's':
                        Console.Write("Welche Zahl möchten Sie subtrahieren? ");
                        userNumber = (Convert.ToInt16(Console.ReadLine()));
                        Console.WriteLine("");
                        foreach (var number in aboveZeroAfterSubtracting)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 'S':
                        Console.Write("Welche Zahl möchten Sie subtrahieren? ");
                        userNumber = (Convert.ToInt16(Console.ReadLine()));
                        Console.WriteLine("");
                        foreach (var number in aboveZeroAfterSubtracting)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Drücken Sie 'Enter'");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }
    }
}
