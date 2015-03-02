using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_to_text
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value;

            decimal.TryParse(Console.ReadLine(), out value);
            
            separate(value);

        }

        private static void separate(decimal valueDecimal)
        {
            decimal newValueDecimal = valueDecimal;
            
            int tenthousands = Convert.ToInt16((newValueDecimal - (newValueDecimal%10000))/10000);
            newValueDecimal = newValueDecimal - (tenthousands*10000);

            int thousands = Convert.ToInt16((newValueDecimal - (newValueDecimal%1000))/1000);
            newValueDecimal = newValueDecimal - (thousands * 1000);

            int hundreds = Convert.ToInt16((newValueDecimal - (newValueDecimal%100))/100);
            newValueDecimal = newValueDecimal - (hundreds * 100);

            int tens = Convert.ToInt16((newValueDecimal - (newValueDecimal%10))/10);
            newValueDecimal = newValueDecimal - (tens * 10);

            int ones = Convert.ToInt16((newValueDecimal - (newValueDecimal%1))/1);
            newValueDecimal = newValueDecimal - (ones * 1);

            
            Console.WriteLine("10k:{0} 1k:{1} 1h:{2} tens:{3} ones:{4}",tenthousands, thousands, hundreds, tens, ones);
        }

    }
}
