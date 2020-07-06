using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace laba
{
    class Program
    {
        class Kniga
        {
            public string name;
            public string familia;
            public string numberPhone;
            public string data;
            public string otch;
            public string country;
            public string org;
            public string dolzh;
            public string other;
            public Kniga(string name,  string numberPhone, string familia, string data, string otch, string country, string org, string dolzh, string other)
            {
                this.name = name;
                this.numberPhone = numberPhone;
                this.familia = familia;
                this.name = name;
                this.data = data;
                this.otch = otch;
                this.country = country;
                this.org = org;
                this.dolzh = dolzh;
                this.other = other; 
            }

            public void vivod()
            {
                Console.WriteLine(this.name + this.numberPhone + this.familia);
            }

            public override string ToString()
            {
                return "Имя: " + this.name + "\nФамилия: " + familia + "\nТелефон: " + numberPhone + "\nДата рождения:" + this.data + "\nОтчество: " + otch + "\nСтрана: " + country + "\nОрганизация: " +  org + "\nДолжность: " + dolzh + "\nДругое: " + other;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество возможных записей в телефонной книжке");
            int A = Convert.ToInt32(Console.ReadLine());
            string[] mass1 = new string[A];
            string[] mass = new string[A];
            string s1;
            string s2;
            string s3;
            string s4;
            string s5;
            string s6;
            string s7;
            string s8;
            string s9;

        startM:
            Console.WriteLine("\nМеню:\n1-Показать\n2-Добавить\n3-Удалить\n4-Редактирование\n5-Краткая Информация");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    int y = 0;
                    for (int i = 0; i < mass.Length-1; i++)
                    {
                        if (mass[i] == null)
                        {
                            y++;
                        }
                        if (mass[i] != null)
                        {
                            Console.WriteLine(mass[i]);
                            Console.WriteLine();
                        }
                    }
                    if (y == mass.Length - 1)
                    { Console.WriteLine("Книжка пуста!"); }
                    goto startM;

                case 2:
                    back1:
                    Console.Write("Введите имя: ");
                    s1 = Console.ReadLine();
                    if (s1 == "")
                    {
                        Console.WriteLine("Данные о имени обязательно!");
                        goto back1;
                    }

                    back2:
                    Console.Write("Введите фамилию: ");
                    s2 = Console.ReadLine();
                    if (s2 == "")
                    {
                        Console.WriteLine("Данные о фамилии обязательно!");
                        goto back2;
                    }

                    Console.Write("Введите телефон: ");
                    s3 = Console.ReadLine();
                    Console.Write("Введите дату рождения: ");
                    s4 = Console.ReadLine();
                    Console.Write("Введите Отчество: ");
                    s5 = Console.ReadLine();
                    Console.Write("Введите Страну: ");

                    back3:
                    s6 = Console.ReadLine();
                    if (s6 == "")
                    {
                        Console.WriteLine("Данные о стране обязательно!");
                        goto back3;
                    }

                    Console.Write("Введите Организацию: ");
                    s7 = Console.ReadLine();
                    Console.Write("Введите Должность: ");
                    s8 = Console.ReadLine();
                    Console.Write("Введите Другое: ");
                    s9 = Console.ReadLine();
                    Kniga kniga = new Kniga(s1, s2, s3, s4, s5, s6, s7, s8, s9);
                    for (int i = 0; i < mass.Length - 1; i++)
                    {
                        if (mass[i] == null)
                        {

                            mass[i] = "Запись под номером " + Convert.ToString(i+1) + "\n" + Convert.ToString(kniga);
                            mass1[i] = "Запись под номером " + Convert.ToString(i + 1) + "\n" + "Имя: " + s1 + "\nФамилия: " + s2 + "\nТелефон: " + s3;
                            break;
                        }
                    }
                    goto startM;

                case 3:
                    Console.WriteLine("Введите запись, которую хотите удалить!");
                    int N = Convert.ToInt32(Console.ReadLine());
                    mass[N-1] = null;
                    mass1[N-1] = null;

                    goto startM;

                case 4:
                    int p = 0;
                    for (int i = 0; i < mass.Length - 1; i++)
                    {
                        if (mass[i] == null)
                        {
                            p++;
                        }
                    }
                    if (p == mass.Length - 1)
                    { Console.WriteLine("Книжка пуста!"); goto startM; }
                    else
                    {
                        aga:
                        Console.WriteLine("Введите запись, которую хотите редактировать!");
                        int g = Convert.ToInt32(Console.ReadLine());
                        if (mass[g - 1] == null)
                        {
                            Console.WriteLine("Запись под номером " + Convert.ToString(g) + " пуста! Выберите заново!");
                            goto aga;
                        }
                    back11:
                        Console.Write("Введите имя: ");
                        s1 = Console.ReadLine();
                        if (s1 == "")
                        {
                            Console.WriteLine("Данные о имени обязательно!");
                            goto back11;
                        }

                    back22:
                        Console.Write("Введите фамилию: ");
                        s2 = Console.ReadLine();
                        if (s2 == "")
                        {
                            Console.WriteLine("Данные о фамилии обязательно!");
                            goto back22;
                        }
                        Console.Write("Введите телефон: ");
                        s3 = Console.ReadLine();
                        s4 = Console.ReadLine();
                        Console.Write("Введите Отчество: ");
                        s5 = Console.ReadLine();
                    back33:
                        s6 = Console.ReadLine();
                        if (s6 == "")
                        {
                            Console.WriteLine("Данные о стране обязательно!");
                            goto back33;
                        }
                        Console.Write("Введите Организацию: ");
                        s7 = Console.ReadLine();
                        Console.Write("Введите Должность: ");
                        s8 = Console.ReadLine();
                        Console.Write("Введите Другое: ");
                        s9 = Console.ReadLine();
                        Kniga kniga1 = new Kniga(s1, s2, s3, s4, s5, s6, s7, s8, s9); ;
                        mass[g - 1] = "Запись под номером " + Convert.ToString(g) + "\n" + Convert.ToString(kniga1);
                        goto startM;
                    }

                case 5:
                    int k = 0;
                    for (int i = 0; i < mass.Length - 1; i++)
                    {
                        if (mass[i] == null)
                        {
                            k++;
                        }
                    }
                    if (k == mass.Length - 1)
                    { Console.WriteLine("Книжка пуста!"); goto startM; }

                    for (int i = 0; i < mass1.Length - 1; i++)
                    {
                        if (mass1[i] != null)
                        {
                            Console.WriteLine(mass1[i]);
                            Console.WriteLine();
                        }
                    }
                    goto startM;
                default:
                    Console.WriteLine("Нет такого пункта Меню!");
                    goto startM;
            } 


        }
    }
}
