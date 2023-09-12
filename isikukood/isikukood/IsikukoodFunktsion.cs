using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            Console.WriteLine("6. Lisa isikukoodi random");
            Console.WriteLine("7. Vaate full info");
            Console.WriteLine("8. Check how old isikukood");

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
                    Console.WriteLine("6. Lisa isikukoodi random");
                    Console.WriteLine("7. Vaate full info");
                    Console.WriteLine("8. Check how old isikukood");
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
                    Console.WriteLine("6. Lisa isikukoodi random");
                    Console.WriteLine("7. Vaate full info");
                    Console.WriteLine("8. Check how old isikukood");
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
                    Console.WriteLine("6. Lisa isikukoodi random");
                    Console.WriteLine("7. Vaate full info");
                    Console.WriteLine("8. Check how old isikukood");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 4)
                {
                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    if (new IdCode(ansIsik).IsValid() == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new IdCode(ansIsik).GetBirthDate());
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
                    Console.WriteLine("6. Lisa isikukoodi random");
                    Console.WriteLine("7. Vaate full info");
                    Console.WriteLine("8. Check how old isikukood");
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
                    Console.WriteLine("6. Lisa isikukoodi random");
                    Console.WriteLine("7. Vaate full info");
                    Console.WriteLine("8. Check how old isikukood");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 6)
                {
                    Random rndArv = new Random();
                    string nameRnd = "";
                    int num = rndArv.Next(0, 8);
                    switch (num)
                    {
                        case 0:
                            nameRnd = "39505279563";
                            break;
                        case 1:
                            nameRnd = "50102153747";
                            break;
                        case 2:
                            nameRnd = "38906102773";
                            break;
                        case 3:
                            nameRnd = "50611279523";
                            break;
                        case 4:
                            nameRnd = "51309236555";
                            break;
                        case 5:
                            nameRnd = "47304066060";
                            break;
                        case 6:
                            nameRnd = "46107166051";
                            break;
                        case 7:
                            nameRnd = "51601085201";
                            break;
                        case 8:
                            nameRnd = "46108277055";
                            break;
                    }
                    IsikukoodList.AddIsikukood(nameRnd);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Isikukood lisanud: " + nameRnd);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("1. Add isikukood");
                    Console.WriteLine("2. Remove isikukood");
                    Console.WriteLine("3. Year isikukood");
                    Console.WriteLine("4. BirthDate isikukood");
                    Console.WriteLine("5. Vaata all isikukoodi");
                    Console.WriteLine("6. Lisa isikukoodi random");
                    Console.WriteLine("7. Vaate full info");
                    Console.WriteLine("8. Check how old isikukood");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 7)
                {
                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    List<char> listAnsik =  ansIsik.ToList();
                    string HaiglaNum = listAnsik[7].ToString() + listAnsik[8].ToString() + listAnsik[9].ToString();
                    int HaiglaNumInt = Convert.ToInt32(HaiglaNum);
                    string haigla = "";
                    if (HaiglaNumInt >= 1 && HaiglaNumInt < 11)
                    {
                        Console.WriteLine(haigla = "Kuressaare Haigla");
                    }
                    else if (HaiglaNumInt >= 11 && HaiglaNumInt < 20)
                    {
                        Console.WriteLine(haigla = "Tartu Ülikooli Naistekliinik, Tartumaa, Tartu");
                    }
                    else if (HaiglaNumInt >= 20 && HaiglaNumInt < 221)
                    {
                        Console.WriteLine(haigla = "Ida-Tallinna Keskhaigla, Pelgulinna sünnitusmaja, Hiiumaa, Keila, Rapla haigla, Loksa haigla");
                    }
                    else if (HaiglaNumInt >= 221 && HaiglaNumInt < 271)
                    {
                        Console.WriteLine(haigla = "Ida-Viru Keskhaigla (Kohtla-Järve, endine Jõhvi)");
                    }
                    else if (HaiglaNumInt >= 271 && HaiglaNumInt < 371)
                    {
                        Console.WriteLine(haigla = "Maarjamõisa Kliinikum (Tartu), Jõgeva Haigla");
                    }
                    else if (HaiglaNumInt >= 371 && HaiglaNumInt < 421)
                    {
                        Console.WriteLine(haigla = "Narva Haigla");
                    }
                    else if (HaiglaNumInt >= 421 && HaiglaNumInt < 471)
                    {
                        Console.WriteLine(haigla = "Pärnu Haigla");
                    }
                    else if (HaiglaNumInt >= 471 && HaiglaNumInt < 491)
                    {
                        Console.WriteLine(haigla = "Pelgulinna Sünnitusmaja (Tallinn), Haapsalu haigla");
                    }
                    else if (HaiglaNumInt >= 491 && HaiglaNumInt < 521)
                    {
                        Console.WriteLine(haigla = "Järvamaa Haigla (Paide)");
                    }
                    else if (HaiglaNumInt >= 521 && HaiglaNumInt < 571)
                    {
                        Console.WriteLine(haigla = "Rakvere, Tapa haigla");
                    }
                    else if (HaiglaNumInt >= 571 && HaiglaNumInt < 601)
                    {
                        Console.WriteLine(haigla = "Valga Haigla");
                    }
                    else if (HaiglaNumInt >= 601 && HaiglaNumInt < 651)
                    {
                        Console.WriteLine(haigla = "Viljandi Haigla");
                    }
                    else if (HaiglaNumInt >= 651 && HaiglaNumInt < 701)
                    {
                        Console.WriteLine(haigla = "Lõuna-Eesti Haigla (Võru), Põlva Haigla");
                    }
                    Console.WriteLine(new IdCode(ansIsik).GetBirthDate());
                    if (new IdCode(ansIsik).GetGenderNumber()% 2 == 0)
                    {
                        Console.WriteLine("Naine");
                    }
                    else 
                    {
                        Console.WriteLine("Mehe");
                    }
                    Console.WriteLine(2023 - new IdCode(ansIsik).GetFullYear());
                    

                }
                while (ans==8)
                {
                    

                }
            
            }
        }
        
     }
    
}
