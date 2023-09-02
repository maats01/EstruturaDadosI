int[,] matrizGeral = new int[3,3];
int winner = 0;
int[] oneOrZero = new int[] { 0, 1 }; 

static void ImprimirMatriz(int[,] matriz)
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
static int WinnerChecker(int[,] matriz)
{
    int winner = 0;
    int soma;
    // checando as linhas
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        soma = 0;
        for(int j = 0; j < matriz.GetLength(1); j++)
            soma += matriz[i,j];

        if(soma == 3)
        {
            winner = 1;
            return winner;
        }
    }

    // checando colunas
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        soma = 0;
        for(int i = 0; i < matriz.GetLength(0); i++)
            soma += matriz[i,j];

        if(soma == 3)
        {
            winner = 1;
            return winner;
        }
    }

    // checando diagonais
    soma = 0;
    for(int i = 0; i < matriz.GetLength(0); i++)
        soma += matriz[i,i];
    if(soma == 3)
    {
        winner = 1;
        return winner;
    }
    if(matriz[2,0] + matriz[1,1] + matriz[0,2] == 3)
    {
        winner = 1;
        return winner;
    }

    return winner;
}

while(winner-1 != 0)
{
    Console.WriteLine("Digite 0 ou 1: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(!(oneOrZero.Contains(num)))
        while(!(oneOrZero.Contains(num)))
        {
            Console.WriteLine("Número diferente de 0 ou 1, digite novamente: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
    Console.WriteLine("Digite a linha: ");
    int linha = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite a coluna: ");
    int coluna = Convert.ToInt32(Console.ReadLine());

    matrizGeral[linha-1, coluna-1] = num;
    ImprimirMatriz(matrizGeral);
    winner = WinnerChecker(matrizGeral);
}
Console.WriteLine("O jogo acabou.");