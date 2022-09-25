using System.Text.RegularExpressions;
class Task23
{

    public Task23()
    {
        int digitN = MainClass.readInteger("Введите число для кубов");
        int[] array = new int[digitN];

        Console.WriteLine("Таблица кубов для " + digitN);
        String msg = "";
        for (int i = 1; i <= digitN; i++)
        {
            msg = msg + "," + Math.Pow(i, 3);
        }
        msg = Regex.Replace(msg, @"^,", "");

        Console.WriteLine(msg);


    }
}