using System;

public class Program
{
    private const int TAM = 2;

    private static Random random = new Random();

    public static bool JogoAdivinhacao(int[] numeroSecreto, int[] numeroChute)
    {
        for (int i = 0; i < TAM; i++)
        {
            numeroSecreto[i] = random.Next(1, 6);
        }

        for (int i = 0; i < TAM; i++)
        {
            Console.Write($"Digite o {i + 1}º número (de 1 a 5): ");

            if (!int.TryParse(Console.ReadLine(), out numeroChute[i]))
            {
                numeroChute[i] = 0;
            }
        }

        bool acertouAlgum = false;

        for (int i = 0; i < TAM; i++)
        {
            if (numeroChute[i] == numeroSecreto[i])
            {
                Console.WriteLine($"{numeroChute[i]} igual a {numeroSecreto[i]}");
                acertouAlgum = true;
            }
            else
            {
                Console.WriteLine($"{numeroChute[i]} diferente de {numeroSecreto[i]}");
            }
        }

        if (acertouAlgum)
        {
            Console.WriteLine("Parabéns, acertou um ou mais! Jogue novamente.");
            return false;
        }
        else
        {
            Console.WriteLine("Não acertou, paga prenda!");
            return true;
        }
    }

    public static void Main(string[] args)
    {
        int[] numeroSecreto = new int[TAM];
        int[] numeroChute = new int[TAM];
        bool naoAcertou = true;

        Console.WriteLine("*************************************");
        Console.WriteLine("* Bem-vindos ao jogo da adivinhação *");
        Console.WriteLine("*************************************");

        while (naoAcertou)
        {
            naoAcertou = JogoAdivinhacao(numeroSecreto, numeroChute);
            Console.WriteLine();
        }

        Console.WriteLine("Fim de jogo. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}