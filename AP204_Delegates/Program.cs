using System;
using System.Collections.Generic;
using System.Linq;

namespace AP204_Delegates
{
    class Program
    {

        public delegate bool Callback(int number);
        public delegate void CustomConcat(string name,string surname);
        public delegate void Convert(int number);
        static void Main(string[] args)
        {
            int[] arr = { 1, 20, 30, 5, 35, 13, 17, 22, 24,21 ,42 };

            //Console.WriteLine("Evens: \n");
            //Console.WriteLine(SumEven(arr));
            //Console.WriteLine("Odd: \n");
            //Console.WriteLine(SumOdd(arr));
            //Console.WriteLine("Divided by 7: \n");
            //Console.WriteLine(SumDividedBy7(arr));

            //Console.WriteLine();
            //Console.WriteLine("Delegate: ");

            //Console.WriteLine("Delegate with 3:");
            //Console.WriteLine(Sum(arr,IsDividedBy3));
            //Console.WriteLine("Delegate with 7:");
            //Console.WriteLine(Sum(arr,IsDividedBy7));
            //Console.WriteLine("Delegate with odd:");
            //Console.WriteLine(Sum(arr,IsOdd));
            //Console.WriteLine("Delegate with even:");
            //Console.WriteLine(Sum(arr, IsEven));

            //CustomConcat customConcat = new CustomConcat(Fullname);

            //customConcat("Kamal", "Abishli");

            //CustomConcat abbr = Abbreviation;

            //abbr.Invoke("Malik", "Safarov");


            //Console.WriteLine("Multi cast delegate");
            //CustomConcat write = customConcat + abbr;

            //write.Invoke("Shemsi","Bayramli");


            //Convert convertToDollar = new Convert(ConvertToDollar);

            ////convertToDollar(100);

            //Convert converttoEuro = ConvertToEuro;

            ////converttoEuro(200);

            //Console.WriteLine("Multi cast delegate");



            //convertToDollar += converttoEuro;
            //convertToDollar(100);

            //convertToDollar -= converttoEuro;
            //Console.WriteLine("After minus");
            //convertToDollar.Invoke(200);


            //// Anonymous delegates
            //Convert convertToAznandTl = delegate (int num)
            //{
            //    Console.WriteLine(num + "Azn");
            //};



            //convertToAznandTl += delegate (int num)
            // {
            //     Console.WriteLine(num + "TL");
            // };

            //convertToAznandTl(300);

            ////Lambda expression

            //Callback callback = n => n % 5 == 0;

            //Console.WriteLine(callback(12)) ;

            //CustomConcat customConcat1 = (string n, string s) => Console.WriteLine(n + " " + s);

            //customConcat1.Invoke("Fatima", "Hasanzade");



            //Action<string,int> action = methodForAction;

            //action("Okay",5);

            //Action action1 = delegate ()
            //{
            //    Console.WriteLine("Hello world");
            //};

            //action1();

            //Action<string, string> fullname = Fullname;

            //fullname("Fatima", "hasanzade");

            //Func<int> func = Test;

            //Console.WriteLine(func()) ;

            //Func<string, int> parse = delegate (string num)
            // {
            //     int number;
            //     bool result = int.TryParse(num, out number);
            //     if (result)
            //     {
            //         return number;
            //     }
            //     return 0;
            // };

            //Console.WriteLine(parse("20")) ;


            Predicate<int> pre = x => x > 0 && x<10;
            Console.WriteLine(pre(8));

            Predicate<string> isUpper = word => word.Equals(word.ToUpper()) && word.Contains("a".ToUpper());

            Console.WriteLine(isUpper("MALIK"));

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(10);
            list.Add(9);
            list.Add(7);
            list.Add(5);
            list.Add(15);
            list.Add(24);

            //int number = list.Find(x=>x>10);

            //Console.WriteLine(number);

            var numbers = list.Where(x=> x % 2 ==0 && x>10);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


        }

        public static int Sum(int[] arr, Callback method)
        {
            int total = default(int);

            foreach (int num in arr)
            {
                if (method(num))
                {
                    total += num;
                }
            }
            return total;
        }

        //public static int SumEven(int[] arr)
        //{
        //    int total = default(int);

        //    foreach (int num in arr)
        //    {
        //        if(IsEven(num))
        //        {
        //            total += num;
        //        }
        //    }
        //    return total;
        //}

        //public static int SumOdd(int[] arr)
        //{
        //    int total = default(int);

        //    foreach (int num in arr)
        //    {
        //        if(IsOdd(num))
        //        {
        //            total += num;
        //        }
        //    }

        //    return total;
        //}

        //public static int SumDividedBy7(int[] arr)
        //{
        //    int total = default(int);

        //    foreach (int num in arr)
        //    {
        //        if (IsDividedBy7(num))
        //        {
        //            total += num;
        //        }
        //    }

        //    return total;
        //}

        //public static int SumDividedBy3(int[] arr)
        //{
        //    int total = default(int);

        //    foreach (int num in arr)
        //    {
        //        if (IsDividedBy3(num))
        //        {
        //            total += num;
        //        }
        //    }

        //    return total;
        //}

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsDividedBy3(int number)
        {
            return number % 3 == 0;
        }

        public static bool IsDividedBy7(int number)
        {
            return number % 7 == 0;
        }

        public static bool IsDividedBy5(int number)
        {
            return number % 5 == 0;
        }

        public static void Fullname(string name, string surname)
        {
            Console.WriteLine($"{name} {surname}") ;
        }

        public static void Abbreviation(string name, string surname)
        {
            Console.WriteLine($"{char.ToUpper(name[0])}.{char.ToUpper(surname[0])}");
        }


        public static void ConvertToDollar(int number)
        {
            Console.WriteLine(number + "$");
        }

        public static void ConvertToEuro(int number)
        {
            Console.WriteLine(number + "€");
        }

        public static void methodForAction(string word,int number)
        {
            Console.WriteLine(word + number);
        }

        public static int Test()
        {
            return 5;
        }
    }
}
