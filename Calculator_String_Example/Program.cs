using System;

namespace Calculator_String_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Calculator String Example In Csharp
            //          For   Intiger Numbric
            //       Hossein Molaei
            string text, convertnumber1, convertnumber2;
            double number1, number2;
            int index;
            char op;
            Console.WriteLine("Pleas enter the value");
            text = Console.ReadLine();
            for(int i = 0; i < text.Length; i++)
            {
                if((text[i]=='+')|| (text[i] == '-') || (text[i] == '/') || (text[i] == '*'))
                {
                    op = text[i];
                    switch (op)
                    {
                        case '+':
                            {
                                index = text.IndexOf('+');   //Hossein Molaei
                                convertnumber1 = text.Substring(0, index);
                                convertnumber2 = text.Substring(++index);
                                Console.WriteLine($"convertnumber1 : {convertnumber1}   "+
                                    $"    convertnumber2 : {convertnumber2}   " +
                                    $"    operator : {op}");
                                number1 = Convert.ToDouble(convertnumber1);
                                number2 = Convert.ToDouble(convertnumber2);
                                Console.WriteLine($"sum : {number1 + number2}");
                                break;
                            }
                        case '-':
                            {
                                index = text.IndexOf('-');    //Hossein Molaei
                                convertnumber1 = text.Substring(0, index);
                                convertnumber2 = text.Substring(++index);
                                Console.WriteLine($"convertnumber1 : {convertnumber1}   " +
                                    $"    convertnumber2 : {convertnumber2}   " +
                                    $"    operator : {op}");
                                number1 = Convert.ToDouble(convertnumber1);
                                number2 = Convert.ToDouble(convertnumber2);
                                Console.WriteLine($"mines : {number1 - number2}");
                                break;
                            }
                        case '/':
                            {
                                index = text.IndexOf('/');   //Hossein Molaei
                                convertnumber1 = text.Substring(0, index);
                                convertnumber2 = text.Substring(++index);
                                Console.WriteLine($"convertnumber1 : {convertnumber1}   " +
                                    $"    convertnumber2 : {convertnumber2}   " +
                                    $"    operator : {op}");
                                number1 = Convert.ToDouble(convertnumber1);
                                number2 = Convert.ToDouble(convertnumber2);
                                Console.WriteLine($"divide : {number1 / number2}");
                                break;
                            }
                        case '*':
                            {
                                index = text.IndexOf('*');   //Hossein Molaei
                                convertnumber1 = text.Substring(0, index);
                                convertnumber2 = text.Substring(++index);
                                Console.WriteLine($"convertnumber1 : {convertnumber1}   " +
                                    $"    convertnumber2 : {convertnumber2}   " +
                                    $"    operator : {op}");
                                number1 = Convert.ToDouble(convertnumber1);
                                number2 = Convert.ToDouble(convertnumber2);
                                Console.WriteLine($"multiple : {number1 * number2}");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("error");
                                break;
                            }
                    }
                }
            }
        }
    }
}
