namespace Sci.CSharp.Kaua.Amaral
{
    internal class CincoCSharp
    {
        public void Execute()
        {
            // 5 - Crie uma matriz bidimensional. Deverá ser solicitado três nomes de alunos e quatro notas,
            // após solicitação dos nomes e das notas deverá ser impresso os nomes acompanhados da média geral de cada aluno,
            // deverá ser impresso também o nome do aluno que obteve a maior média e o nome do aluno que obteve a menor média.

            string[,] students = new string[3, 5];

            for (var i = 0; i < 3; i++)
            {
                Console.Clear();

                Console.Write($"Digite o nome do {i + 1}° aluno: ");
                students[i, 0] = Console.ReadLine();

                var noteSum = 0.0;

                for (var j = 1; j <= 4; j++)
                {
                    var numberString = true;

                    while (numberString == true)
                    {
                        try
                        {
                            Console.Write($"Digite a {j}° nota: ");
                            students[i, j] = Console.ReadLine();
                            noteSum += Convert.ToDouble(students[i, j]);

                            if (Convert.ToDouble(students[i, j]) < 0)
                            {
                                Console.Clear();

                                Console.WriteLine(@"Nota Inválida!
");

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

                            Console.WriteLine(@"Válido apenas números!
");
                        }
                    }
                }
                var average = noteSum / 4;

                students[i, 4] = average.ToString();
            }
            Console.Clear();

            Console.WriteLine(@$"Alunos e suas médias:
");

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($@"{students[i, 0]}: {students[i, 4]}
");
            }
            var higherAverage = double.MinValue;
            var nameHigherAverage = "";

            for (var i = 0; i < 3; i++)
            {
                var average = Convert.ToDouble(students[i, 4]);

                if (average > higherAverage)
                {
                    higherAverage = average;
                    nameHigherAverage = students[i, 0];
                }
            }
            Console.WriteLine(@$"Aluno com a maior média: {nameHigherAverage} média: {higherAverage}
");

            var lowerAverage = double.MaxValue;
            var nameLowerAverage = "";

            for (var i = 0; i < 3; i++)
            {
                var average = Convert.ToDouble(students[i, 4]);

                if (average < lowerAverage)
                {
                    lowerAverage = average;
                    nameLowerAverage = students[i, 0];
                }
            }
            Console.WriteLine($"Aluno com a menor média: {nameLowerAverage} média: {lowerAverage}");
        }
    }
}