//1. Faça um programa que leie um número inteiro e imprima até esta posição (a quantidade de números que o usuário pedir), da sequência fibonacci

int posicao, penultimo = 0, ultimo = 1, atual;

Console.WriteLine("--- Fibonacci ---\n");

do
{
    Console.Write("Digite um número inteiro e maior que zero, para verificar a posição: ");
    posicao = int.Parse(Console.ReadLine());

    if (posicao <= 0)
        Console.WriteLine("\nResposta Incorreta!\n");
} while (posicao <= 0);

if (posicao == 1)
    Console.WriteLine($"\n1ª posição: {penultimo}");
else
{
    if (posicao == 2)
    {
        Console.WriteLine($"\n1ª posição: {penultimo}");
        Console.WriteLine($"2ª posição: {ultimo}");
    }
    else
    {
        Console.WriteLine($"\n1ª posição: {penultimo}");
        Console.WriteLine($"2ª posição: {ultimo}");

        for (int i = 3; i <= posicao; i++)
        {
            atual = penultimo + ultimo;
            penultimo = ultimo;
            ultimo = atual;

            Console.WriteLine($"{i}ª posição: {atual}");
        }
    }
}

Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();