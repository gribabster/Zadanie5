using System;
using static System.Convert;
using static System.Console;
using System.Collections.Generic;


namespace Zadanie5
{
    class lol

    {
        public class Student

        {
            public string ID;

            public string FIO;

            public string GROUP;

            public string DATA;

        }

        public List<Student> list = new List<Student>();

        public void add(string ID, string FIO, string GROUP, string DATA)

        {
            list.Add(new Student() { ID = ID, FIO = FIO, GROUP = GROUP, DATA = DATA });
        }

        public void remov(string ID)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].ID == ID) list.RemoveAt(i);
            }
        }

        public void change(string ID, string FIO, string GROUP, string DATA)

        {
            for (int i = 0; i < list.Count; i++)

            {
                if (list[i].ID == ID)

                {
                    list[i].FIO = FIO;

                    list[i].GROUP = GROUP;

                    list[i].DATA = DATA;

                }

            }

        }

        public void show()

        {
            foreach (var i in list)

            {
                Console.WriteLine(i.ID + " " + i.FIO + " " + i.GROUP + " " + i.DATA);
            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            lol a = new lol();

            WriteLine("1 - Dobavit studenta.\n2 - Izmenit dannye studenta.\n3 - Udalit studenta.\n4 - Vse studenty.");

            int n = ToInt32(ReadLine());

            while (n > 0)

            {

                if (n == 1)

                {
                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("FIO: "); string FIO = ReadLine();

                    WriteLine("Group: "); string GROUP = ReadLine();

                    WriteLine("Data: "); string DATA = ReadLine();

                    a.add(ID, FIO, GROUP, DATA);

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 2)

                {
                    WriteLine("Vvod ID i i izmen. dannyh: ");

                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("FIO: "); string FIO = ReadLine();

                    WriteLine("Group: "); string GROUP = ReadLine();

                    WriteLine("Data: "); string DATA = ReadLine();

                    a.change(ID, FIO, GROUP, DATA);

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 3)

                {
                    WriteLine("Vvod ID: ");

                    string ID = ReadLine();

                    a.remov(ID);

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }

                else if (n == 4)

                {
                    a.show();

                    WriteLine("Vvod deist: ");

                    n = ToInt32(ReadLine());

                }

            }

        }

    }

}
