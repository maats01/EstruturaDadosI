string[,] matrizGeral = new string[3,3]
{
    {"-", "-", "-"},
    {"-", "-", "-"},
    {"-", "-", "-"}
};
int winner = 0;

static void ImprimirMatriz(string[,] matriz)
// ImprimirMatriz recebe uma matriz de argumento e a imprime no console
{
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i,j] + " ");
        }
        Console.WriteLine("");
    }
}
static int WinnerChecker(string[,] matriz)
{
    int winner = 0;
    string soma;
    // checando as linhas
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        soma = "";
        for(int j = 0; j < matriz.GetLength(1); j++)
            soma += matriz[i,j];

        if(soma == "XXX" || soma == "OOO")
        {
            winner = 1;
            return winner;
        }
    }

    // checando colunas
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        soma = "";
        for(int i = 0; i < matriz.GetLength(0); i++)
            soma += matriz[i,j];

        if(soma == "XXX" || soma == "OOO")
        {
            winner = 1;
            return winner;
        }
    }

    // checando diagonais
    soma = "";
    for(int i = 0; i < matriz.GetLength(0); i++)
        soma += matriz[i,i];
    if(soma == "XXX" || soma == "OOO")
    {
        winner = 1;
        return winner;
    }
    if(matriz[2,0] + matriz[1,1] + matriz[0,2] == "XXX" || matriz[2,0] + matriz[1,1] + matriz[0,2] == "OOO")
    {
        winner = 1;
        return winner;
    }

    return winner;
}
static (int, int, string) Player1(string[,] matriz)
{
    string value = "X";
    int linha;
    int coluna;
    while(true)
    {
    Console.WriteLine("Jogador 1");
    Console.WriteLine("Linha: ");
    linha = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Coluna: ");
    coluna = Convert.ToInt32(Console.ReadLine());
    if(matriz[linha-1, coluna-1] == "-")
        break;
    }
    return (linha, coluna, value);
}
static (int, int, string) Player2(string[,] matriz)
{
    string value = "O";
    int linha;
    int coluna;
    while(true)
    {
    Console.WriteLine("Jogador 2");
    Console.WriteLine("Linha: ");
    linha = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Coluna: ");
    coluna = Convert.ToInt32(Console.ReadLine());
    if(matriz[linha-1, coluna-1] == "-")
        break;
    }
    return (linha, coluna, value);
}

while(winner-1 != 0)
{
    (int linha, int coluna, string value) = Player1(matrizGeral);
    matrizGeral[linha-1, coluna-1] = value;
    ImprimirMatriz(matrizGeral);

    winner = WinnerChecker(matrizGeral);
    if(winner-1 == 0)
        break;

    (linha, coluna, value) = Player2(matrizGeral);
    matrizGeral[linha-1, coluna-1] = value;
    ImprimirMatriz(matrizGeral);

    winner = WinnerChecker(matrizGeral);
}
Console.WriteLine("O jogo acabou.");