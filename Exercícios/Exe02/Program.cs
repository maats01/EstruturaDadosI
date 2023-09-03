string[,] matrizGeral = new string[3,3]
{
    {"-", "-", "-"},
    {"-", "-", "-"},
    {"-", "-", "-"}
};

string winner;

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
    int winCheck = 0;
    string soma;

    // checando empate
    if(stringChecker(matriz, "-"))
    {
        return winCheck = 2;
    }

    // checando as linhas
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        soma = "";
        for(int j = 0; j < matriz.GetLength(1); j++)
            soma += matriz[i,j];

        if(soma == "XXX" || soma == "OOO")
        {
            return winCheck = 1;
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
            return winCheck = 1;
        }
    }

    // checando diagonais
    soma = "";
    for(int i = 0; i < matriz.GetLength(0); i++)
        soma += matriz[i,i];
    if(soma == "XXX" || soma == "OOO")
    {
        return winCheck = 1;
    }
    if(matriz[2,0] + matriz[1,1] + matriz[0,2] == "XXX" || matriz[2,0] + matriz[1,1] + matriz[0,2] == "OOO")
    {
       return winCheck = 1;
    }

    return winCheck;
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

static string LastMove(string[,] matriz, int i, int j)
{
    string PlayerWinner;
    if(matriz[i-1 ,j-1] == "X")
        PlayerWinner = "Jogador 1";
    else
        PlayerWinner = "Jogador 2";
    
    return PlayerWinner;
}

static bool stringChecker(string[,] matriz, string str)
{
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            if(matriz[i,j] == str)
                return false;
        }
    }
    return true;
}

while(true)
{
    // inputs do jogador 1
    (int linha, int coluna, string value) = Player1(matrizGeral);
    matrizGeral[linha-1, coluna-1] = value;
    ImprimirMatriz(matrizGeral);

    int winCheck = WinnerChecker(matrizGeral);
    if(winCheck == 2)
    {
        Console.WriteLine("O jogo empatou!");
        Environment.Exit(0);
    }
    else if(winCheck == 1)
    {
        winner = LastMove(matrizGeral, linha, coluna);
        break;
    }

    // inputs do jogador 2
    (linha, coluna, value) = Player2(matrizGeral);
    matrizGeral[linha-1, coluna-1] = value;
    ImprimirMatriz(matrizGeral);

    winCheck = WinnerChecker(matrizGeral);
    if(winCheck == 1)
    {
        winner = LastMove(matrizGeral, linha, coluna);
        break;
    }

}
Console.WriteLine("O jogo acabou.");
Console.WriteLine($"{winner} venceu!");