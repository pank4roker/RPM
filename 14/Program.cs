using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        //Этот код создает пользовательский делегат MyDelegate с сигнатурой Action<Func<int>, char>,
        //а затем создает экземпляр делегата, который вызывает переданный метод типа Func<int>
        //и выводит его результат вместе с переданным символом.
        // Определение пользовательского делегата
        delegate void MyDelegate(Func<int> func, char c);

        static void Main(string[] args)
        {
            // Создание экземпляра делегата с помощью лямбда-выражения
            MyDelegate myDelegate = (func, c) =>
            {
                // Вызов переданной функции и передача ей результата в метод Console.WriteLine()
                Console.WriteLine($"Result: {func()}, Char: {c}");
            };

            // Вызов метода, передаваемого в делегат, и символа 'A'
            myDelegate(() => 42, 'A');

            // Вызов другого метода и символа 'B'
            myDelegate(() => 10 * 5, 'B');
            Console.ReadKey();
        }
    }
}
