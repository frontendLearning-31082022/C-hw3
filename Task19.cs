class Task19
{

    public Task19()
    {
        int digit55555 = MainClass.readInteger("Введите пятизначное число");
        String digString = digit55555.ToString();

        if (digString.Length != 5)
        {
            Console.WriteLine("Введено не пятизначное число. Ошибка");
            Environment.Exit(1);
        }

        char[] charArray = digString.ToCharArray();
        Array.Reverse(charArray);
        String digStringReverse = new string(charArray);

        if (digStringReverse.Equals(digString))
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }

    }
}