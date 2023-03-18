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
            double note1, note2, note3, note4, average;
            char option;

            do
            {
                Console.Write("Nome do aluno: ");
                name = Console.ReadLine();

                Console.Write("1° nota: ");
                note1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2° nota: ");
                note2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("3° nota: ");
                note3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("4° nota: ");
                note4 = Convert.ToDouble(Console.ReadLine());

                average = (note1 + note2 + note3 + note4) / 4;

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