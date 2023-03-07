using System.Security.AccessControl;

int[] vetorA = new int[3];
int[] vetorB = new int[3];
int[] vetorC = new int[vetorA.Length + vetorB.Length];

int IMenu()
{
    Console.WriteLine("Digite um valor: ");
    return RetornaErro(Console.ReadLine());
}

int[] PreencherVetor(int[] vetorAux, string texto)
{
    for (int i = 0; i < vetorAux.Length; i++)
    {
        Console.WriteLine($"Posição {i + 1} do {texto}");
        vetorAux[i] = IMenu();
    }
    return vetorAux;
}

int RetornaErro(string valor)
{

    int num;
    if (!int.TryParse(valor, out num))
    {
        Console.WriteLine("Informe um número válido");
        return IMenu();
    }
    return num;
}

int[] CopiarVetor(int[] vetorA, int[] vetorB)
{
    int[] vetorAux = new int[vetorA.Length + vetorB.Length];

    for (int i = 0; i < vetorA.Length; i++)
    {
        vetorAux[i] = vetorA[i];
    }
    for (int i = 0; i < vetorB.Length; i++)
    {
        vetorAux[i + vetorA.Length] = vetorB[i];
    }

    return vetorAux;

}


void Print(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"{vetor[i]}, ");
    }
    Console.WriteLine("");
}

void OrdenaVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        for (int j = i + 1; j < vetor.Length; j++)
        {
            if (vetor[j] < vetor[i])
            {
                int aux = vetor[j];
                vetor[j] = vetor[i];
                vetor[i] = aux;
            }

        }
    }
}

PreencherVetor(vetorA, "Vetor A");
PreencherVetor(vetorB, "Vetor B");

vetorC = CopiarVetor(vetorA, vetorB);

Console.WriteLine("Vetor A: ");
Print(vetorA);
Console.WriteLine();
Console.WriteLine("Vetor B: ");
Print(vetorB);
Console.WriteLine();
Console.WriteLine("Vetor C: ");
Print(vetorC);
Console.WriteLine();

OrdenaVetor(vetorC);
Console.WriteLine("Vetor C ordenado: ");
Print(vetorC);
Console.WriteLine();