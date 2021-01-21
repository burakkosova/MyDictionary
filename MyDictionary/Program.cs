using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> openWith = new MyDictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            try
            {
                openWith.Add("txt", "notepad.exe");
            }
            catch (Exception)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            openWith.Add("bmp", "paint.exe");

            Console.WriteLine();
            for (int i = 0; i < openWith.Keys.Length; i++)
            {
                    Console.WriteLine("Key = {0}, Value = {1}",openWith.Keys[i],openWith.Values[i]);
            }

            Console.WriteLine();
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\"");
            }
        }
    }
}
