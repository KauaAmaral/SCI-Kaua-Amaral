namespace Sci.CSharp.Kaua.Amaral
{
    internal class TresCSharp
    {
        public void Execute()
        {
            // 3- Elabore um programa de computador que realize o cálculo de notas.
            // Este programa deverá solicitar o nome do aluno e quatro notas,
            // todo este conjunto deverá estar contido em um laço que confirme se deseja encerrar o programa ou continuar solicitando outros nomes e notas.
            // Ao final da solicitação do nome e das notas deverá ser impresso o nome do aluno e a sua média,
            // se a nota for  menor que 6 imprimir Reprovado, senão, se a nota for igual ou maior que 6, imprimir Aprovado.

            string name;
            double[] notes = new double[4];
            double average;
            char option;

            do
            {
                Console.Clear();

                Console.Write("Nome do aluno: ");
                name = Console.ReadLine();

                for (var i = 0; i < notes.Length; i++)
                {
                    var numberString = true;

                    while (numberString == true)
                    {
                        try
                        {
                            Console.Write($"{i + 1}° nota: ");
                            notes[i] = Convert.ToDouble(Console.ReadLine());

                            if (notes[i] < 0)
                            {
                                Console.Clear();

                                Console.WriteLine("Nota inválida!");

                                numberString = true;
                            }
                            else
                            {
                                numberString = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();

                            Console.WriteLine("Válido apenas números!");
                        }
                    }
                }
                Console.Clear();

                average = (notes[0] + notes[1] + notes[2] + notes[3]) / 4;

                Console.WriteLine(@$"Aluno: {name}
Média: {average}");

                if (average < 6)
                    Console.WriteLine("Situação: Reprovadado");

                if (average >= 6)
                    Console.WriteLine("Situação: Aprovado");

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                option = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (option != 'S');
        }
    }
}