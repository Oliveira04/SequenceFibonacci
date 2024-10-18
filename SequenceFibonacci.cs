using System;

class Program
{
    static bool PertenceFibonacci(int number)
    {
        // Iniciando os dois primeiros números da sequência de Fibonacci
        int previous  = 0, 
        int current  = 1;

        // Gera a sequência de Fibonacci até o número ser maior que o informado
        while (previous <= numer)
        {
            if (previous == number)
            {
                return true; // Se o número pertence à sequência de Fibonacci
            }
            // Atualiza os valores para o próximo número da sequência
            int temp = previous;
            previous = current;
            current = temp + current;
        }

        return false; // Se o número não pertence à sequência de Fibonacci
    }

    static void Main(string[] args)
    {
        // Solicita a entrada do usuário
        Console.Write("Informe um número: ");
        int number = int.Parse(Console.ReadLine());

        // Verifica se o número pertence à sequência de Fibonacci
        if (PertenceFibonacci(number))
        {
            Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {number} NÃO pertence à sequência de Fibonacci.");
        }
    }
}
