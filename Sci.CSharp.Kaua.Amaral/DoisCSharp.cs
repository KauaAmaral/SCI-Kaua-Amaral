namespace Sci.CSharp.Kaua.Amaral
{
    internal class DoisCSharp
    {
        public void Execute()
        {
            // 2 - Solicitar 5 números, ao fim, imprimir o número maior e o número menor.

            double[] numbers = new double[5];
            var bigger = double.MinValue;
            var smaller = double.MaxValue;

            for (var i = 0; i < numbers.Length; i++)
            {
                var numberString = true;

                while (numberString == true)
                {
                    try
                    {
                        Console.Write($"Digite o {i + 1}° número: ");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());

                        if (numbers[i] > bigger)
                            bigger = numbers[i];

                        if (numbers[i] < smaller)
                            smaller = numbers[i];

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

            Console.WriteLine(@$"O maior número é: {bigger}

O menor número é: {smaller}");
        }
    }
}