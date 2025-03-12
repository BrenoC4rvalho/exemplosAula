// See https://aka.ms/new-console-template for more information
using Aula02._1bim;


bool entradaInvalida = true;
do
{
    try
    {

        Console.WriteLine("Menu");
        Console.WriteLine("1 - Metro para milimetros.");
        Console.WriteLine("2 - Somar dois numeros.");
        Console.WriteLine("3- sair.");

        int opcao = int.Parse(Console.ReadLine());

        if(opcao == 1)
        {
            SomaDoisNumeros somador = new SomaDoisNumeros();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int resultado = somador(n1, n2);
            Console.WriteLine($"O valor da soma de {n1} e {n2} é igual {resultado} ");

        }

        if (opcao == 2)
        {
            Console.Write("Informe o valor em metros: ");
            int metros = int.Parse(Console.ReadLine());
            Console.WriteLine($"O valor {metros} metros corresponde a {MetrosMilimetros.ConverterMetrosEmMilimetros(metros)} milímetros");
            entradaInvalida = false;
        }

        if(opcao == 3)
        {
            entradaInvalida = false;
        }
    } 
    catch (Exception e)
    {
        Console.WriteLine("O valor informado foi inválido.\n" + e.Message);
    }

} while (entradaInvalida);

