using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1;

public delegate void Func(string str);

public class MyClass
{
    public string str { get; set; }

    public MyClass(string Str)
    {
        str = Str;
    }
    

    public void Space(string str)
    {
        string result = string.Join("_", str.ToCharArray());
        Console.WriteLine(result);
    }
    
    
    public void Reverse(string str) {

        for (int i = str.Length -1; i >=0; i--)
        {
            Console.Write(str[i]);
        }
        
    }
}

public class Run
{
    public void runFunc(Func qutu , string str)
    {
        if (qutu!= null)
        {
            qutu.Invoke(str);
        }   
    }
}    

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Ayzi daxil edin: ");
        var str = Console.ReadLine();

        MyClass arr = new MyClass(str);

        Func funcDell = new Func(arr.Space);
        funcDell += arr.Reverse;
        Run run = new Run();
        run.runFunc(funcDell, str);
    }
}




