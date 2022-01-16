using System;
namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////
            //////////Date Time/////////////
            ////////////////////////////////

            DateTime dateTime = new DateTime(2022, 01, 8);
            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Now);
            DateTime MyBirthday = new DateTime(2022, 12, 22);
            DateTime MyDadBirthday = new DateTime(1976, 4, 14);
            Console.WriteLine(MyDadBirthday.ToLongDateString());
            Console.WriteLine(MyBirthday.AddYears(22));
            Console.WriteLine(MyBirthday.ToShortDateString());

        }
    }
}
