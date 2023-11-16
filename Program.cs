using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp37
{



    #region Task
    class MyClass
    {

        public void Space(string str )
        {
            string newStr = "";
            foreach (var letter in str)
            {
                newStr += letter;
                newStr += "_";
            }
            str = newStr;
            Console.WriteLine(str); 
        }

        public void Reverse(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr += str[str.Length - i-1];
            }
            str = newStr;
            Console.WriteLine(str); 
        }
    }

    class Run
    {
        public void runFunc(Func func,string str)
        {
            func.Invoke(str);
        }
    }

    public delegate void Func(string str);
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = new Func(cls.Reverse) ; // params sadece sizin ora vereceyiniz parametrlerdi	
            funcDell += cls.Space;
            //burda funcDell-e functionlari verirsiniz
           Run run = new Run();
           run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
        }
    }
    #endregion
}
