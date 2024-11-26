using System;

class Program{
    static void Main(string[] args){
        Counter c = new Counter();
        c.Add(3);
        c.Add(5);
        Console.WriteLine(c.Val());
        
    }
}