using System.Security.AccessControl;

int[] vetorA = new int[5];
int[] vetorB = new int[5];
int[] vetorC = new int[10];

int Imenu()
{
    Console.WriteLine("Digite um valor: ");
    return retornaErro(Console.ReadLine());
}

int[] preencherVetor()
{
    int[] vetorAux = new int[5];

    for (int i = 0; i < vetorAux.Length; i++)
    {
        Console.WriteLine($"Posição {i+1} do vetor");
        vetorAux[i] = Imenu();
    }
    return vetorAux;
}

int retornaErro(string valor)
{

    int num;
    if (!int.TryParse(valor, out num))
    {
        Console.WriteLine("Informe um número válido");
        return Imenu();
    }
    return num;
}

int[] copiarVetor(int[] vetorA, int[] vetorB)
{
    int[] vetorAux = new int[10];

    for (int i = 0; i < 5; i++)
    {
        vetorAux[i] = vetorA[i];
    }
    for (int i = 5; i < 10; i++)
    {
        vetorAux[i] = vetorB[i - 5];
    }

    return vetorAux;

}


void print(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"{vetor[i]}, ");
    }
    Console.WriteLine("");
}

vetorA = preencherVetor();
vetorB = preencherVetor();

vetorC = copiarVetor(vetorA, vetorB);

Console.WriteLine("Vetor A: ");
print(vetorA);
Console.WriteLine();
Console.WriteLine("Vetor B: ");
print(vetorB);
Console.WriteLine();
Console.WriteLine("Vetor C: ");
print(vetorC);
Console.WriteLine();