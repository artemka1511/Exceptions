using System;

namespace Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {

            Exception[] exceptions = new Exception[] { new SuperException("Тестовое сообщение для ошибки."), new OverflowException(),
                    new DivideByZeroException(), new FormatException(), new UnauthorizedAccessException() };

            for (int i = 0; i < exceptions.Length; i++)
            {
                
                try
                {
                    throw exceptions[i];
                }
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);   Можно реализовать так. Я не понял как нужно :(
                //    continue;
                //}
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (SuperException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
