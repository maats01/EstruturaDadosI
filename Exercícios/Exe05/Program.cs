/*
Atividade: escreva um programa que seja capaz de interagir com o usuário utilizando o console.writeline() e o console.readline().
	Você deve solicitar ao usuário os pares chave e valor para a tabela hash que vai armazenar, respectivamente, CPF e nome.
	O programa deve:
	1. Checar se a chave já foi previamente inserida;
	2. Realizar as devidas validações para evitar possíveis interrupções;
	3. Percorrer e exibir todos os dados inseridos pelo usuário.
*/

using System.Collections;

Hashtable tabela = new Hashtable();

while(true)
{
    Console.WriteLine("\nKey: ");
    string? cpf = Console.ReadLine();
    Console.WriteLine("Value: ");
    string? nome = Console.ReadLine();

    try
    {
        tabela.Add(cpf, nome);
    }
    catch(ArgumentException ae)
    {
        Console.WriteLine("\n Chave inválida.");
        Console.WriteLine($"Detalhes: {ae.Message}");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"\nErro genérico.");
        Console.WriteLine($"Detalhes: {ex}");
    }

    Console.WriteLine("\nDeseja adicionar mais um elemento na tabela? [s/n]");
    if(!(Console.ReadLine() == "s"))
    {
        break;
    }
}

foreach(DictionaryEntry de in tabela)
{
    Console.WriteLine("{0}: {1}", de.Key, de.Value);
}