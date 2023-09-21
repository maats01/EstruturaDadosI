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

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Key: ");
    int cpf = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Value: ");
    string nome = Console.ReadLine();

    try
    {
        tabela.Add(cpf, nome);
    }
    catch
    {
        
    }
}