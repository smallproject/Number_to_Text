using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_to_text
{
    class Program
    {
        public static decimal Decimalinput { get; set; }
        public static int ones { get; set; }
        public static int tens { get; set; }
        public static int hundreds { get; set; }
        public static int thousands { get; set; }
        public static int millions { get; set; }
        public static int billions { get; set; }
        public static int trillions { get; set; }

        static void Main(string[] args)
        {
            decimal value;

            decimal.TryParse(Console.ReadLine(), out value);

            Decimalinput = value;

            separatedigits(Decimalinput);
            converttoText();
        }

        private static void separatedigits(decimal valueDecimal)
        {
            string stringvalue = "";
            decimal newValueDecimal = valueDecimal;
            
            millions = Convert.ToInt16((newValueDecimal - (newValueDecimal%1000000))/1000000);
            newValueDecimal = newValueDecimal - (millions * 10000);

            thousands = Convert.ToInt16((newValueDecimal - (newValueDecimal%1000))/1000);
            newValueDecimal = newValueDecimal - (thousands * 1000);

            hundreds = Convert.ToInt16((newValueDecimal - (newValueDecimal%100))/100);
            newValueDecimal = newValueDecimal - (hundreds * 100);

            tens = Convert.ToInt16((newValueDecimal - (newValueDecimal%10))/10);
            newValueDecimal = newValueDecimal - (tens * 10);

            ones = Convert.ToInt16((newValueDecimal - (newValueDecimal % 1)) / 1);
            newValueDecimal = newValueDecimal - (ones * 1);
            
            Console.WriteLine("10k:{0} 1k:{1} 1h:{2} tens:{3} ones:{4}",millions, thousands, hundreds, tens, ones);


        }

        private static void converttoText()
        {
            string stringvalue = "";

            if (billions != 0)
            {
                stringvalue = stringvalue + billionstext(billions);
                addSpace(stringvalue);
            }

            if (millions != 0)
            {
                stringvalue = stringvalue + millionstext(millions);
                addSpace(stringvalue);
            }

            if (thousands != 0)
            {
                stringvalue = stringvalue + thousandtext(thousands);
                addSpace(stringvalue);
            }

            if (hundreds != 0)
            {
                stringvalue = stringvalue + hundredstext(hundreds);
                addSpace(stringvalue);
            }

            if (tens != 0)
            {
                if (tens >= 2)
                {
                    stringvalue = stringvalue + tenstext(tens);
                    addSpace(stringvalue);
                }
                else
                {
                    int twenties = (tens*10) + ones;
                    stringvalue = stringvalue + twentiestext(twenties);
                    addSpace(stringvalue);
                    ones = 0;
                }

            }

            if (Decimalinput != 0)
            {
                stringvalue = stringvalue + onestext(ones);
            }
            else
            {
                stringvalue = zero();
            }

            Console.WriteLine(stringvalue);
        }

        private static string addSpace(string value)
        {
            if (value != "")
            {
                value = value + " ";
            }
            return value;
        }

        private static string zero()
        {
            return "zero";
        }

        private static string onestext(int value)
        {
            string stringvalue = "";

            switch (value)
            {
                case 1:
                    stringvalue = "one";
                    break;

                case 2:
                    stringvalue = "two";
                    break;

                case 3:
                    stringvalue = "three";
                    break;

                case 4:
                    stringvalue = "four";
                    break;

                case 5:
                    stringvalue = "five";
                    break;

                case 6:
                    stringvalue = "six";
                    break;

                case 7:
                    stringvalue = "seven";
                    break;  

                case 8:
                    stringvalue = "eight";
                    break;

                case 9:
                    stringvalue = "nine";
                    break;
            }

            return stringvalue;
        }

        private static string twentiestext(int value)
        {
            string stringvalue = "";
            switch (value)
            {
                case 10:
                    stringvalue = "ten";
                    break;

                case 11:
                    stringvalue = "eleven";
                    break;

                case 12:
                    stringvalue = "twelve";
                    break;

                case 13:
                    stringvalue = "thirteen";
                    break;

                case 14:
                    stringvalue = "fourteen";
                    break;

                case 15:
                    stringvalue = "fifteen";
                    break;

                case 16:
                    stringvalue = "sixteen";
                    break;

                case 17:
                    stringvalue = "seventeen";
                    break;

                case 18:
                    stringvalue = "eighteen";
                    break;

                case 19:
                    stringvalue = "nineteen";
                    break;
            }

            return stringvalue;
        }

        private static string tenstext(int value)
        {
            string stringvalue = "";
            switch (value)
            {
                case 2:
                    stringvalue = "twenty";
                    break;

                case 3:
                    stringvalue = "thirty";
                    break;

                case 4:
                    stringvalue = "fourty";
                    break;

                case 5:
                    stringvalue = "fifty";
                    break;

                case 6:
                    stringvalue = "sixty";
                    break;

                case 7:
                    stringvalue = "seventy";
                    break;

                case 8:
                    stringvalue = "eighty";
                    break;

                case 9:
                    stringvalue = "ninety";
                    break;
            }

            return stringvalue;
        }

        private static string hundredstext(int value)
        {
            string stringvalue = onestext(value) + " hundred";
            return stringvalue;
        }

        private static string thousandtext(int value)
        {
            string stringvalue = onestext(value) + " thousand";
            return stringvalue;
        }


        private static string millionstext(int value)
        {
            string stringvalue = onestext(value) + " million";
            return stringvalue;
        }

        private static string billionstext(int value)
        {
            string stringvalue = onestext(value) + " billion";
            return stringvalue;
        }

        private static string trillionstext(int value)
        {
            string stringvalue = onestext(value) + " trillion";
            return stringvalue;
        }

    }
}
