using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken_2 = "CSharp";

            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            Console.WriteLine(degisken.CompareTo(degisken_2));
            Console.WriteLine(String.Compare(degisken,degisken_2,true));
            Console.WriteLine(String.Compare(degisken,degisken_2,false));

            Console.WriteLine(degisken.Contains(degisken_2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("mahmut"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            Console.WriteLine(degisken + degisken_2.PadLeft(30));
            Console.WriteLine(degisken + degisken_2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken_2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken_2);

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));
            
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            Console.WriteLine(degisken.Split(' ')[1]);

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

        }
    }
}
