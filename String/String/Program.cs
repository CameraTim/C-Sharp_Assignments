using System;
using System.Text;
class Program
    {
        static void Main()
        {
        string str1 = "This is ";
        string str2 = "a text ";
        string str3 = "sentence.";
        string str = (str1 + str2 + str3).ToUpper();
        Console.WriteLine(str);
        StringBuilder sb = new StringBuilder();
        sb.Append(str1);
        sb.Append(str2);
        sb.Append(str3);
        Console.WriteLine(sb);
        Console.ReadLine();

    }
    }
