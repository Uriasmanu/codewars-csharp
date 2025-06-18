using System;

namespace MinhaBiblioteca
{
    using System;

    public class KataCalculator
    {
        public static double Calculator(object a, object b, char operation)
        {
            // Verifica se os dois valores s�o n�meros
            if (!(a is int || a is double) || !(b is int || b is double))
            {
                throw new ArgumentException("unknown value");
            }

            // Converte para double
            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);

            // Executa a opera��o
            return operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num2 != 0 ? num1 / num2 : throw new ArgumentException("Divis�o por zero n�o � permitida."),
                _ => throw new ArgumentException("unknown value")
            };
        }
    }

}