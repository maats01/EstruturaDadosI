using System.Collections;

// Criar HashTable
Hashtable openWith = new Hashtable();

try
{
    openWith.Add("txt", "notepad.exe");
    openWith.Add("bmp", "paint.exe");
    openWith.Add("dib", "paint.exe");
    openWith.Add("rtf", "wordpad.exe");

    openWith.Add("txt", "notepad++.exe");
}
catch(ArgumentException aex)
{
    Console.WriteLine("Oops. Você tentou adicionar uma chave inválida.");
    Console.WriteLine($"Detalhes do erro: {aex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("Erro genérico.");
    throw ex;
}

// Acessando o conteúdo da tabela hash
Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"]);

// Alterando o contúdo da tabela hash
openWith["rtf"] = "winword.exe";
Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"]);

// Testar se chave existe na hash
if(!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada");
}

// Percorrendo hash com foreach
Console.WriteLine();
foreach(DictionaryEntry de in openWith)
{
    Console.WriteLine("Key = {0} - Value = {1}", de.Key, de.Value);
}

// Obtendo apenas os valores do hash
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}

// Obtendo apenas as keys do hash
ICollection keyCol = openWith.Values;
Console.WriteLine();
foreach(string s in keyCol)
{
    Console.WriteLine("key = {0}", s);
}

// Remover registro do hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc"))
{
    Console.WriteLine("Chave \"doc\" foi removida.");
}