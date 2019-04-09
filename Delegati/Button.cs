using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    public class Button
    {
        public event Action<OutButtonEventArgs>ClickEvent;
//Action не возвращает а принимает
//Func возвращает
//Predicate true or false 
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
    
      

        public void Click()
        {
            //При нажатии изменяем размер и цвет если надо
            //if (clickButtonDelegate != null)
            //    clickButtonDelegate(new OutButtonEventArgs());
            ClickEvent?.Invoke(new OutButtonEventArgs());
            //clickButtonDelegate.Invoke(new OutButtonEventArgs()); одно и тоже
        }
    }
}
