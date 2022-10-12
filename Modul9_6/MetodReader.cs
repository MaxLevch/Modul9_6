using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9_6
{
    internal class MetodReader
    {
        string[] array;
        public delegate void MetodDelegate(int metod, string[] array);
        public event MetodDelegate MetodEnteredEvent;

        public void Read()
        {
            Console.WriteLine("Введите 1 для сортировки по возрастанию, 2 для сортировки по убыванию");
            int metod = Convert.ToInt32(Console.ReadLine());
            if (metod != 1 && metod != 2) throw new Exception("Некорректное число");
            MetodEntered(metod, array); 
        }

        protected virtual void MetodEntered(int metod, string[] array)
        {
            MetodEnteredEvent?.Invoke(metod, array);
        }
        public MetodReader(string[] arr)
        {
            array = arr;
        }
    }
}
