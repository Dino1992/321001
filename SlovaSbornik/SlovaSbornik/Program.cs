using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SlovaSbornik
{
    class Program
    {
    [STAThread]
        static void Main(string[] args)
        {
            string str;
            Parser a;
            List<string> words;
            
            Console.WriteLine("Скопируйте текст в буфер обмена.");
            while ((string)Clipboard.GetText()=="") 
            {
               
            }
            str = Clipboard.GetText();
            a = new Parser();
           words= a.SplitString(str);
        for (int i=0; i<words.Count;i++)
        {
            Console.WriteLine(words[i]);
            if (i > 1000) break;
        }
        Console.WriteLine("Нажмите Escape для выхода.");
        while (Console.ReadKey().Key!=ConsoleKey.Escape)
        {

        }
        
        }

       
    }
}
