using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace isikukood
{
    public class IdCode

    {

            private readonly string _idCode;

            public IdCode(string idCode)
            {
                _idCode = idCode;
            }

            private bool IsValidLength()
            {
                return _idCode.Length == 11;
            }

            private bool ContainsOnlyNumbers()
            {
                // return _idCode.All(Char.IsDigit);

                for (int i = 0; i < _idCode.Length; i++)
                {
                    if (!Char.IsDigit(_idCode[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            public int GetGenderNumber()
            {
                return Convert.ToInt32(_idCode.Substring(0, 1));
            }
            public List<string> isikukodi { get; } = new List<string>();
            public IdCode IsikukodList { get; }

            private readonly int _maxAmount;

            private bool IsValidGenderNumber()
            {
                int genderNumber = GetGenderNumber();
                return genderNumber > 0 && genderNumber < 7;
            }

            private int Get2DigitYear()
            {
                return Convert.ToInt32(_idCode.Substring(1, 2));
            }

            public int GetFullYear()
            {
                int genderNumber = GetGenderNumber();
                // 1, 2 => 18xx
                // 3, 4 => 19xx
                // 5, 6 => 20xx
                return 1800 + (genderNumber - 1) / 2 * 100 + Get2DigitYear();
            }
            public void GetHaigla(string iskukood)
            {
                List<char> listAnsik = iskukood.ToString().ToList();
                string HaiglaNum = listAnsik[7].ToString() + listAnsik[8].ToString() + listAnsik[9].ToString();
                int HaiglaNumInt = Convert.ToInt32(HaiglaNum);
                if (HaiglaNumInt >= 1 && HaiglaNumInt < 11)
                {
                    Console.WriteLine("Kuressaare Haigla");
                }
                else if (HaiglaNumInt >= 11 && HaiglaNumInt < 20)
                {
                    Console.WriteLine("Tartu Ülikooli Naistekliinik, Tartumaa, Tartu");
                }
                else if (HaiglaNumInt >= 20 && HaiglaNumInt < 221)
                {
                    Console.WriteLine("Ida-Tallinna Keskhaigla, Pelgulinna sünnitusmaja, Hiiumaa, Keila, Rapla haigla, Loksa haigla");
                }
                else if (HaiglaNumInt >= 221 && HaiglaNumInt < 271)
                {
                    Console.WriteLine("Ida-Viru Keskhaigla (Kohtla-Järve, endine Jõhvi)");
                }
                else if (HaiglaNumInt >= 271 && HaiglaNumInt < 371)
                {
                    Console.WriteLine("Maarjamõisa Kliinikum (Tartu), Jõgeva Haigla");
                }
                else if (HaiglaNumInt >= 371 && HaiglaNumInt < 421)
                {
                    Console.WriteLine("Narva Haigla");
                }
                else if (HaiglaNumInt >= 421 && HaiglaNumInt < 471)
                {
                    Console.WriteLine("Pärnu Haigla");
                }
                else if (HaiglaNumInt >= 471 && HaiglaNumInt < 491)
                {
                    Console.WriteLine("Pelgulinna Sünnitusmaja (Tallinn), Haapsalu haigla");
                }
                else if (HaiglaNumInt >= 491 && HaiglaNumInt < 521)
                {
                    Console.WriteLine("Järvamaa Haigla (Paide)");
                }
                else if (HaiglaNumInt >= 521 && HaiglaNumInt < 571)
                {
                    Console.WriteLine("Rakvere, Tapa haigla");
                }
                else if (HaiglaNumInt >= 571 && HaiglaNumInt < 601)
                {
                    Console.WriteLine("Valga Haigla");
                }
                else if (HaiglaNumInt >= 601 && HaiglaNumInt < 651)
                {
                    Console.WriteLine("Viljandi Haigla");
                }
                else if (HaiglaNumInt >= 651 && HaiglaNumInt < 701)
                {
                    Console.WriteLine("Lõuna-Eesti Haigla (Võru), Põlva Haigla");
                }
                if (new IdCode(iskukood).GetGenderNumber() % 2 == 0)
                {
                    Console.WriteLine("Naine");
                }
                else
                {
                    Console.WriteLine("Mees");
                }
            }

            private int GetMonth()
            {
                return Convert.ToInt32(_idCode.Substring(3, 2));
            }

            private bool IsValidMonth()
            {
                int month = GetMonth();
                return month > 0 && month < 13;
            }

            private static bool IsLeapYear(int year)
            {
                return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
            }
            private int GetDay()
            {
                return Convert.ToInt32(_idCode.Substring(5, 2));
            }

            private bool IsValidDay()
            {
                int day = GetDay();
                int month = GetMonth();
                int maxDays = 31;
                if (new List<int> { 4, 6, 9, 11 }.Contains(month))
                {
                    maxDays = 30;
                }
                if (month == 2)
                {
                    if (IsLeapYear(GetFullYear()))
                    {
                        maxDays = 29;
                    }
                    else
                    {
                        maxDays = 28;
                    }
                }
                return 0 < day && day <= maxDays;
            }

            private int CalculateControlNumberWithWeights(int[] weights)
            {
                int total = 0;
                for (int i = 0; i < weights.Length; i++)
                {
                    total += Convert.ToInt32(_idCode.Substring(i, 1)) * weights[i];
                }
                return total;
            }
            public void vivod()
            {
                Console.WriteLine("1. Add isikukood");
                Console.WriteLine("2. Remove isikukood");
                Console.WriteLine("3. Year isikukood");
                Console.WriteLine("4. BirthDate isikukood");
                Console.WriteLine("5. Vaata all isikukoodi");
                Console.WriteLine("6. Lisa isikukoodi random");
                Console.WriteLine("7. Vaate full info");
            }

            private bool IsValidControlNumber()
            {
                int controlNumber = Convert.ToInt32(_idCode[^1..]);
                int[] weights = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
                int total = CalculateControlNumberWithWeights(weights);
                if (total % 11 < 10)
                {
                    return total % 11 == controlNumber;
                }
                // second round
                int[] weights2 = { 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
                total = CalculateControlNumberWithWeights(weights2);
                if (total % 11 < 10)
                {
                    return total % 11 == controlNumber;
                }
                // third round, control number has to be 0
                return controlNumber == 0;
            }

            public bool IsValid()
            {
                return IsValidLength() && ContainsOnlyNumbers()
                    && IsValidGenderNumber() && IsValidMonth()
                    && IsValidDay()
                    && IsValidControlNumber();
            }

            public DateOnly GetBirthDate()
            {
                int day = GetDay();
                int month = GetMonth();
                int year = GetFullYear();
                return new DateOnly(year, month, day);
            }
            public IdCode(int maxAmount)
            {
                _maxAmount = maxAmount;
            }

            public bool AddIsikukood(string isikukood)
            {
                string fullName = isikukood;
                if (isikukodi.Contains(fullName)) return false;
                if (isikukodi.Count >= _maxAmount) return false;
                isikukodi.Add(fullName);
                return true;
            }
            public bool RemoveIsikukood(string isikukood)
            {
                string fullName = isikukood;
                isikukodi.Remove(fullName);
                return true;
            }

            public static void FunktsionIsikukood()
            {

            IdCode IsikukoodList = new IdCode(99);

            IsikukoodList.vivod();

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
                    IsikukoodList.vivod();
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 2)
                {

                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    IsikukoodList.RemoveIsikukood(ansIsik);
                    IsikukoodList.vivod();
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
                    IsikukoodList.vivod();
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
                    IsikukoodList.vivod();
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 5)
                {
                    Console.WriteLine(string.Join(", ", IsikukoodList.isikukodi));
                    IsikukoodList.vivod();
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
                    IsikukoodList.vivod();
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                while (ans == 7)
                {

                    Console.WriteLine("Sisse Isikukood");
                    string ansIsik = Console.ReadLine();
                    IdCode idCode = new IdCode(ansIsik);
                    idCode.GetHaigla(ansIsik);
                    Console.WriteLine(2022 - new IdCode(ansIsik).GetFullYear());
                    Console.WriteLine(new IdCode(ansIsik).GetBirthDate());
                    IsikukoodList.vivod();
                    ans = Convert.ToInt32(Console.ReadLine());
                }
            }
            }
        }
    }



