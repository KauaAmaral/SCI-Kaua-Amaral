namespace Sci.CSharp.Kaua.Amaral
{
    internal class QuatroCSharp
    {
        public void Execute()
        {
            //  4- Criar um vetor de cinco posições, solicitar  cinco números e ao fim, imprimir o valor apresentado na posição três.

            double[] numbers = new double[5];

            for (var i = 0; i < numbers.Length; i++)
            {
                var numberString = true;

                while (numberString == true)
                {
                    try
                    {
                        Console.Write($"Digite o {i + 1}° número: ");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());

                        numberString = false;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();

                        Console.WriteLine(@"Válido apenas números!
");
                    }
                }
            }
            Console.Clear();

            Console.WriteLine($"O valor apresentado na posição três é: {numbers[2]}");
        }
    }
}