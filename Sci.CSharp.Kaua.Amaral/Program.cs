using Sci.CSharp.Kaua.Amaral;

Console.WriteLine(@"-----Menu-----

1- UmCSharp
2- DoisCSharp
3- TresCSharp
4- QuatroCSharp
5- CincoCSharp
");

var option = 0;

while ((option <= 0) || (option > 5))
{
    try
    {
        Console.Write("Digite a opção desejada: ");
        option = Convert.ToInt32(Console.ReadLine());

        if ((option <= 0) || (option > 5))
        {
            Console.WriteLine(@"
Válido apenas números do menu!
");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(@"
Válido apenas números do menu!
");
    }
}
Console.Clear();

if(option == 1)
{
    UmCSharp umCSharp = new UmCSharp();
    umCSharp.Execute();
}
else if (option == 2)
{
    DoisCSharp doisCSharp = new DoisCSharp();
    doisCSharp.Execute();
}
else if (option == 3)
{
    TresCSharp tresCSharp = new TresCSharp();
    tresCSharp.Execute();
}
else if (option == 4)
{
    QuatroCSharp quatroCSharp = new QuatroCSharp();
    quatroCSharp.Execute();
}
else if (option == 5)
{
    CincoCSharp cincoCSharp = new CincoCSharp();
    cincoCSharp.Execute();
}