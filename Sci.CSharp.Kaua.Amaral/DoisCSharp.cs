namespace Sci.CSharp.Kaua.Amaral
{
    internal class DoisCSharp
    {
        public void Execute()
        {
            // 2 - Solicitar 5 números, ao fim, imprimir o número maior e o número menor.

            double[] numbers = new double[5];
            var bigger = numbers[0];
            var smaller = numbers[0];

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° número: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());

                if (numbers[i] > bigger)
                    bigger = numbers[i];

                if (numbers[i] < smaller)
                    smaller = numbers[i];
            }

            Console.WriteLine(@$"O maior número é: {bigger}
O menor número é: {smaller}");
        }
    }
}