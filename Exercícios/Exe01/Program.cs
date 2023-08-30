int[] vetor = { 5, 6, 3, 1, 7, 9, 0, 8, 2, 10 };

// imprimindo vetor desordenado
for (int i = 0; i < vetor.Length; i++)
    Console.WriteLine(vetor[i]);

Console.WriteLine("--------------------");

// ordenando o vetor
for (int i = 0; i < vetor.Length - 1; i++)
    for (int j = i + 1; j < vetor.Length; j++)
    {
        if (vetor[i] > vetor[j])
        {
            int aux = vetor[j];
            vetor[j] = vetor[i];
            vetor[i] = aux;
        }
    }

// imprimindo vetor ordenado
for (int i = 0; i < vetor.Length; i++)
    Console.WriteLine(vetor[i]);