using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main()
    {

        Task19 task19 = new Task19();
        Task21 task21 = new Task21();
        Task23 task23 = new Task23();

    }


    public static int readInteger(String msg)
    {

        Boolean itsOK = false;

        while (!itsOK)
        {
            Console.WriteLine(msg);

            try
            {
                String input = Console.ReadLine();
                String st = Regex.Replace(input, "\\D", "");


                //  Console.WriteLine("поменяно "+st);
                if (st.Length == 0)
                {
                    Console.WriteLine("ошибка, введите число.");
                    continue;
                }


                int res = int.Parse(st);
                Console.WriteLine("(Введено число " + res + ")");
                return res;
            }
            catch (Exception) { continue; }
        }



        return 0;
    }

    static void Exception(Exception exception)
    {
        Console.WriteLine(exception);
        Environment.Exit(1);
    }
}