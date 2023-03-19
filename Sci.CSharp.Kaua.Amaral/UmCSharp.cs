namespace Sci.CSharp.Kaua.Amaral
{
    internal class UmCSharp
    {
        public void Execute()
        {
            // 1 - Solicitar a inserção de 5 números, ao final, imprimir os números pares, números ímpares e a média geral desses números.

            double[] numbers = new double[5];
            var sum = 0.0;


            for (var i = 0; i < numbers.Length; i++)
            {
                var numberString = true;
                while (numberString == true)
                {
                    try
                    {
                        Console.Write($"Digite o {i + 1}° número: ");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());

                        sum += numbers[i];

                        numberString = false;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();

                        Console.WriteLine("Válido apenas números!");
                    }
                }
            }
            Console.Clear();

            Console.WriteLine("Números pares:");

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(@"
Números impares: ");

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    Console.WriteLine(numbers[i]);
            }

            var average = sum / numbers.Length;

            Console.WriteLine($@"
Média geral:
{average}");
        }
    }
}