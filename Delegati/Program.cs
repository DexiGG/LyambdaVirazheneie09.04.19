using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    class Program
    {
        static void Main(string[] args)
        {
            //Делегаты -button 1. ctor, methods, prop.
            Button smallButton = new Button
            {
                Width = 20,
                Height = 20,
                Text = "Нажми меня"
            };
            //smallButton.ClickEvent += Hz;
            //smallButton.ClickEvent += new ClickButtonDelegate(Hz);
            //smallButton.ClickEvent += delegate (OutButtonEventArgs arguments)
            //  {
            //      return;
            //  };


            //ЛЯМБА ВЫРАЖЕНИЯ формула (параметры без типа через запятую) => {тело; return если надо};

            smallButton.ClickEvent += (arguments) => Console.WriteLine("Меня нажали");

            Button mediumButton = new Button
            {
                Width = 40,
                Height = 40,
                Text = "Нажми меня сильнее"
            };


            Button bigButton = new Button
            {
                Width = 100,
                Height = 100,
                Text = "Ударь меня"
            };

            List<string> names = new List<string>
            {
                "Бахыт",
                "Анвар",
                "Франсуа"
            };
            var result = names.Single(name => name.Contains("Ф"));
        }
        public static void Hz(OutButtonEventArgs args)
        {
            Console.WriteLine("AAAA!Меня нажали!");
        }
    }
}
