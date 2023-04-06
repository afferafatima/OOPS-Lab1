using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            task7();
            task8();
            task9();
            task10();
            task11();
            task12();
            task13();
            task14();
            task15();
            task16();


        }
        static void task1()
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
        static void task2()
        {
            int variable = 456;
            float variable1 = 3.4F;
            string variable2 = "It's me Afeera.";
            char variable3 = 'A';

            Console.WriteLine("integer:{0}", variable);
            Console.WriteLine("Float:{0}", variable1);
            Console.WriteLine("String:{0}", variable2);
            Console.WriteLine("Character:{0}", variable3);

            Console.ReadKey();
        }
        static void task3()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You Have Inputed : {0}", str);
            Console.ReadKey();

        }
        static void task4()
        {
            string str;
            str = Console.ReadLine();
            int num = int.Parse(str);
            Console.WriteLine("You Have Inputed : {0}", num);
            Console.ReadKey();

        }
        static void task5()
        {
            string str;
            str = Console.ReadLine();
            float num = float.Parse(str);
            Console.WriteLine("You Have Inputed : {0}", num);
            Console.ReadKey();

        }
        static void task6()
        {
            float length;
            float area;
            string str;
            Console.Write("Enter length : ");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.Write("The Area is :{0} ", area);

            Console.ReadKey();
        }
        // Manual 2 Conditional
        static void task7()
        {
            string input;
            float marks;
            Console.Write("Enter the Marks: ");
            input = Console.ReadLine();
            marks = float.Parse(input);
            if (marks > 50)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
            Console.ReadKey();
        }
        static void task8()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("OOP lab ");
            }
            Console.Read();

        }
        static void task9()
        {
            int num;
            int sum = 0;
            Console.Write("Enter Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.Write("Enter Number : ");
                num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The total sum is {0}", sum);
            Console.Read();

        }
        static void task10()
        {
            int num;
            int sum = 0;
            do
            {
                Console.Write("Enter Number : ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("The total sum is {0}", sum);
            Console.Read();

        }
        static void task11()
        {
            int[] numbers = new int[3];
            for (int idx = 0; idx < 3; idx++)
            {
                Console.Write("Enter the Number {0}:", idx + 1);
                numbers[idx] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int idx = 0; idx < 3; idx++)
            {
                if (numbers[idx] > largest)
                {
                    largest = numbers[idx];
                }
            }
            Console.WriteLine(" Largest is :{0}", largest);
            Console.Read();
        }
        static void task12()
        {
            int savings = 0;
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Machine Price");
            int machineprice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ToyPrice");
            int toyprice = int.Parse(Console.ReadLine());
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings = savings + ((i / 2) * 10);
                    savings = savings - 1;
                }
                else
                {
                    savings = savings + toyprice;

                }
            }
            if (savings >= machineprice)
            {
                int remaining = savings - machineprice;
                Console.Write("she managed to buy it and is left with {0}Rs ", remaining);
            }
            else
            {
                int required = savings - machineprice;
                Console.Write("she did not manage to buy a washing machine.The insufficiency amount is {0}Rs ", required);
            }
            Console.Read();
        }
        static void task13()
        {
            string path = "E:\\Study\\Semester2\\PF\\WEEK 1\\check.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.Read();
        }
        static void task14()
        {
            string path = "E:\\Study\\Semester2\\PF\\WEEK 1\\check.txt";
            StreamWriter fileVariable = new StreamWriter(path, true);
            fileVariable.WriteLine("Helloo");
            fileVariable.Flush();
            fileVariable.Close();
            Console.Read();
        }
        static void task15()
        {
            string path = "E:\\Study\\Semester2\\PF\\WEEK 1\\lab1\\textfile.txt";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = Menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, password);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter New Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New Password: ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }
            }
            while (option < 3);
            Console.Read();
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void signIn(string n, string p, string[] names, string[] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == names[x] && p == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine(" Invalid User ");
            }
            Console.ReadKey();
        }
        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }

        static void task16()
        {
            Console.Write("Enter Minimum number of Orders: ");
            int orders=int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Order Price: ");
            int price = int.Parse(Console.ReadLine());
            check(orders, price);

        }
        static void check(int orders, int price)
        {
            string path = "E:\\Study\\Semester2\\PF\\WEEK 1\\lab1\\customersData.txt";
            StreamReader fileVariable = new StreamReader(path);
            string record;
            int count = 0;
            while ((record = fileVariable.ReadLine()) != null)
            {
                string name = getField(record, 1);
                int ord = int.Parse(getField(record, 2));
                if(ord>=orders)
                {
                    for (int i = 0; i < ord; i++)
                    {
                        int[] pricearray = new int[100];
                        pricearray[i] = int.Parse(getField(record, 4 + i));
                        if(pricearray[i]>price)
                        {
                            count++;
                        }
                    }
                }
                if(count>=orders)
                {
                    Console.WriteLine(name);
                }
                  //  Console.Read();
            }
            Console.Read();
        }
        static string getField(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ','|| record[x]==' '|| record[x] == '['||record[x] == ']')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
       
    }
}
