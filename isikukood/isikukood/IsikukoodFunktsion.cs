using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IdCode;

namespace isikukood
{
    public class IsikukoodFunktsion
    {
        public static void FunktsionIsikukood()
        {
            IdCode IsikukoodList = new IdCode(99);
            Console.WriteLine("1. Add isikukood");
            Console.WriteLine("2. Remove isikukood");
            Console.WriteLine("3. Year isikukood");
            Console.WriteLine("4. BirthDate isikukood");
            Console.WriteLine("5. Vaata all isikukoodi");
            int ans = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                while (ans == 1)
                {
                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    if (new IdCode(ansIsik).IsValid() == true && IsikukoodList.AddIsikukood(ansIsik) == true)
                    {
                        IsikukoodList.AddIsikukood(ansIsik);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Isikukood lisanud: " + ansIsik);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.WriteLine("1. Add isikukood");
                    Console.WriteLine("2. Remove isikukood");
                    Console.WriteLine("3. Year isikukood");
                    Console.WriteLine("4. BirthDate isikukood");
                    Console.WriteLine("5. Vaata all isikukoodi");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 2)
                {

                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    IsikukoodList.RemoveIsikukood(ansIsik);
                    Console.WriteLine("1. Add isikukood");
                    Console.WriteLine("2. Remove isikukood");
                    Console.WriteLine("3. Year isikukood");
                    Console.WriteLine("4. BirthDate isikukood");
                    Console.WriteLine("5. Vaata all isikukoodi");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 3)
                {
                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    if (new IdCode(ansIsik).IsValid() == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new IdCode(ansIsik).GetFullYear());
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.WriteLine("1. Add isikukood");
                    Console.WriteLine("2. Remove isikukood");
                    Console.WriteLine("3. Year isikukood");
                    Console.WriteLine("4. BirthDate isikukood");
                    Console.WriteLine("5. Vaata all isikukoodi");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 4)
                {
                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    if (new IdCode(ansIsik).IsValid() == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new IdCode("50412033718").GetBirthDate());
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (IsikukoodList.AddIsikukood(ansIsik) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.WriteLine("1. Add isikukood");
                    Console.WriteLine("2. Remove isikukood");
                    Console.WriteLine("3. Year isikukood");
                    Console.WriteLine("4. BirthDate isikukood");
                    Console.WriteLine("5. Vaata all isikukoodi");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 5)
                {
                    Console.WriteLine(string.Join(", ", IsikukoodList.isikukodi));
                    Console.WriteLine("1. Add isikukood");
                    Console.WriteLine("2. Remove isikukood");
                    Console.WriteLine("3. Year isikukood");
                    Console.WriteLine("4. BirthDate isikukood");
                    Console.WriteLine("5. Vaata all isikukoodi");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        
     }
    
}
