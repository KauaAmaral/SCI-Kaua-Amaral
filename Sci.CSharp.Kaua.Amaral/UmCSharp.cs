namespace Sci.CSharp.Kaua.Amaral
{
    internal class UmCSharp
    {
        public void Execute()
        {
            // 1 - Solicitar a inserção de 5 números, ao final, imprimir os números pares, números ímpares e a média geral desses números.

            double[] numbers = new double[5];
            var sum = 0.0;

            // Solicitar a inserção dos 5 números
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° número: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }

            // Imprimir os números pares
            Console.Write("Números pares: ");
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i]);
            }

            // Imprimir   os números impares
            Console.Write("Números impares: ");
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    Console.WriteLine(numbers[i]);
            }

            // Calcular e imprimir média geral
            var average = sum / numbers.Length;
            Console.WriteLine($"Média geral: {average}");
        }
    }
}