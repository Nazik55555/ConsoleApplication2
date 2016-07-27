using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"e:\file.txt";
            link1:
            Console.WriteLine("Введіть шлях до файлу");
            string e = Console.ReadLine();
            string d = @""+e;
            if (File.Exists(d)==true)
            {
                string mas = File.ReadAllText(d);
                char[] arr = mas.ToCharArray();
                Array.Reverse(arr);

                FileInfo file = new FileInfo(s);
                file.Create().Close();
                StreamWriter wr;
                wr = file.AppendText();
                wr.WriteLine(arr);
                wr.Close();
            }
            else
            {
                Console.WriteLine("Неправильно введений шлях");
                Console.ReadKey();
                goto link1;
            }    
            
                
        }
    }
}
