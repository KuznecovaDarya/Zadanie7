using System;
using static System.Convert;
using static System.Console;
using System.Collections.Generic;

namespace ConsoleApp29
{
    class lab
    {
        public class student
        {
            public string id;
            public string fio;
            public string group;
            public string data;
        }
        public List<student> list = new List<student>();
        public void add(string id, string fio, string group, string data)
        {
            list.Add(new student() { id = id, fio = fio, group = group, data = data });
        }
        public void del(string id)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id) list.RemoveAt(i);
            }

        }
        public void izmenie(string id, string fio, string group, string data)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    list[i].fio = fio;
                    list[i].group = group;
                    list[i].data = data;
                }
            }
        }
        public void viv(string id)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    Console.WriteLine(list[i].id + " " + list[i].fio + " " + list[i].group + " " + list[i].data);
                }
            }

        }
        public void years(string id, int day1, int month1, int year1)
        {
            int t1;
            int t2;
            int vozr;
            string day = "";
            string month = "";
            string year = "";
            string dat = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    dat = list[i].data + "";
                }
            }
            t1 = dat.IndexOf(".");
            t2 = dat.LastIndexOf(".");
            for (int i = 0; i < t1; i++)
            {
                day = day + dat[i];
            }
            for (int i = t1 + 1; i < t2; i++)
            {
                month = month + dat[i];
            }
            for (int i = t2 + 1; i < dat.Length; i++)
            {
                year = year + dat[i];
            }
            Console.WriteLine("Дата рождения" + day + "." + month + "." + year);
            vozr = year1 - ToInt32(year);
            if (ToInt32(month) > month1) vozr = vozr - 1;
            else if (ToInt32(month) == month1)
                if (ToInt32(day) < day1) vozr = vozr - 1;
            Console.WriteLine("\nВозраст = " + vozr);
        }
        public void show()
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.fio);
            }

        }
        public void inic(string id)
        {
            string rez = "";
            string prom = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    prom = list[i].fio;
                }
            }
            string[] words = prom.Split(' ');
            rez = rez + words[0] + " " + words[1][0] + "." + words[2][0] + ".";
            Console.WriteLine(rez);
        }
        public void famp(string fam)
        {
            string prom = "";
            for (int i = 0; i < list.Count; i++)
            {
                prom = list[i].fio;
                string[] words = prom.Split(' ');
                if (fam == words[0])
                {
                    Console.WriteLine(list[i].id + " " + list[i].fio + " " + list[i].group + " " + list[i].data);
                }
            }
        }
        public void Vozvr(string param, int day1, int month1, int year1)
        {
            for (int g = 0; g < list.Count; g++)
            {
                int t1;
                int t2;
                int vozr;
                string day = "";
                string month = "";
                string year = "";
                string dat;
                string id;

                id = list[g].id;
                dat = list[g].data + "";

                t1 = dat.IndexOf(".");
                t2 = dat.LastIndexOf(".");
                for (int i = 0; i < t1; i++)
                {
                    day = day + dat[i];
                }
                for (int i = t1 + 1; i < t2; i++)
                {
                    month = month + dat[i];
                }
                for (int i = t2 + 1; i < dat.Length; i++)
                {
                    year = year + dat[i];
                }
                vozr = year1 - ToInt32(year);
                if (ToInt32(month) > month1) vozr = vozr - 1;
                else if (ToInt32(month) == month1)
                    if (ToInt32(day) < day1) vozr = vozr - 1;
                if (param == "s") if (vozr < 18) Console.WriteLine(list[g].fio + " ");
                if (param == "a") if (vozr > 18) Console.WriteLine(list[g].fio + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введи сегодняшнюю дату: ");
            WriteLine("День: ");
            int day = ToInt32(ReadLine());
            WriteLine("Месяц: ");
            int month = ToInt32(ReadLine());
            WriteLine("Год: ");
            int year = ToInt32(ReadLine());

            lab a = new lab();
            WriteLine("1 - Добавление студента.\n2 - Изменение данных о студенте.\n3 - Удаление студента.\n4 - Вывод списка всех студентов.\n5 - Вывод по id студента всей информации о нем.\n6 - Вывод количество лет студента по id.\n7 - Вывод Фамилии и инициалов по id.\n8 - Вывод всех студентов младше или старше 18 лет.\n9 - Поиск по фамилии.");
            int n = ToInt32(ReadLine());
            while (n > 0)
            {
                if (n == 1)
                {
                    WriteLine("ID: "); string id = ReadLine();
                    WriteLine("ФИО: "); string fio = ReadLine();
                    WriteLine("Группа: "); string group = ReadLine();
                    WriteLine("Дата рождения: "); string data = ReadLine();

                    a.add(id, fio, group, data);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 2)
                {
                    WriteLine("Введи ID и измененные данные: ");
                    WriteLine("ID: "); string id = ReadLine();
                    WriteLine("ФИО: "); string fio = ReadLine();
                    WriteLine("Группа: "); string group = ReadLine();
                    WriteLine("Дата: "); string data = ReadLine();
                    a.izmenie(id, fio, group, data);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 3)
                {
                    WriteLine("Введи ID: ");
                    string id = ReadLine();
                    a.del(id);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 4)
                {
                    a.show();
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 5)
                {
                    WriteLine("Введи ID: ");
                    string id = ReadLine();
                    a.viv(id);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 6)
                {
                    WriteLine("Введи ID: ");
                    string id = ReadLine();
                    a.years(id, day, month, year);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 7)
                {
                    WriteLine("Введи ID: ");
                    string id = ReadLine();
                    a.inic(id);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 8)
                {
                    WriteLine("Введи «s» - младше 18, «a» - старше 18: ");
                    string param = ReadLine();
                    a.Vozvr(param, day, month, year);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 9)
                {
                    WriteLine("Введи фамилию: ");
                    string famil = ReadLine();
                    a.famp(famil);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
            }
        }
    }
}
