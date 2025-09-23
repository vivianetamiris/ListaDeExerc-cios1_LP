using System;

class Exercicios
{
    
    // Exercício 1 – Soma de vetores
    static void Exercicio1()
    {
        Console.Write("Informe o tamanho do vetor (N): ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        for (int i = 0; i < n; i++)
            soma += vetor[i];

        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
    }

    
    // Exercício 2 – Números ímpares
    static void Exercicio2()
    {
        Console.Write("Informe o tamanho do vetor (N): ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int impares = 0;
        for (int i = 0; i < n; i++)
            if (vetor[i] % 2 != 0)
                impares++;

        Console.WriteLine($"O vetor possui {impares} número(s) ímpar(es).");
    }

    
    // Exercício 3 – Mostrar menor elemento do vetor
    static void Exercicio3()
    {
        Console.Write("Informe o tamanho do vetor (N): ");
        int n = int.Parse(Console.ReadLine());
        double[] vetor = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        double menor = vetor[0];
        for (int i = 1; i < n; i++)
            if (vetor[i] < menor)
                menor = vetor[i];

        Console.WriteLine("Vetor: " + string.Join(", ", vetor));
        Console.WriteLine($"Menor elemento: {menor}");
    }

    
    // Exercício 4 – Mostrar maior elemento do vetor
    static void Exercicio4()
    {
        Console.Write("Informe o tamanho do vetor (N): ");
        int n = int.Parse(Console.ReadLine());
        double[] vetor = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        double maior = vetor[0];
        for (int i = 1; i < n; i++)
            if (vetor[i] > maior)
                maior = vetor[i];

        Console.WriteLine("Vetor: " + string.Join(", ", vetor));
        Console.WriteLine($"Maior elemento: {maior}");
    }

    
    // Exercício 5 – DNA 
    static void Exercicio5()
    {
        Console.WriteLine("Digite a sequência de DNA (máx 50 bases, A, T, C, G):");
        string dna = Console.ReadLine().ToUpper();
        char[] complementar = new char[dna.Length];

        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'A': complementar[i] = 'T'; break;
                case 'T': complementar[i] = 'A'; break;
                case 'C': complementar[i] = 'G'; break;
                case 'G': complementar[i] = 'C'; break;
                default: complementar[i] = '?'; break;
            }
        }

        Console.WriteLine("DNA complementar: " + new string(complementar));
    }

    
    // Exercício 6 – Verificar número digitado no vetor 
    static void Exercicio6()
    {
        Random rnd = new Random();
        Console.Write("Informe N: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
            vetor[i] = rnd.Next(1, 101);

        Console.WriteLine("Vetor gerado: " + string.Join(", ", vetor));

        Console.Write("Digite um número para verificar: ");
        int num = int.Parse(Console.ReadLine());

        int pos = Array.IndexOf(vetor, num);
        if (pos >= 0)
            Console.WriteLine($"Número encontrado na posição {pos}");
        else
            Console.WriteLine("Número não encontrado.");
    }

    
    // Exercício 7 – Multiplicação de vetores
    static void Exercicio7()
    {
        Console.Write("Informe N: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];
        int[] resultado = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite elemento {i + 1} do vetor 1: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite elemento {i + 1} do vetor 2: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
            resultado[i] = vetor1[i] * vetor2[i];

        Console.WriteLine("Vetor resultante: " + string.Join(", ", resultado));
    }

    
    // Exercício 8 – Contar ocorrências de um valor
    static void Exercicio8()
    {
        Console.Write("Informe N: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o valor a contar: ");
        int valor = int.Parse(Console.ReadLine());

        int count = 0;
        foreach (int v in vetor)
            if (v == valor) count++;

        Console.WriteLine("Vetor: " + string.Join(", ", vetor));
        Console.WriteLine($"O valor {valor} aparece {count} vezes.");
    }

    
    // Exercício 9 – Vetor invertido
    static void Exercicio9()
    {
        Console.WriteLine("Digite uma sequência de caracteres:");
        char[] vetor = Console.ReadLine().ToCharArray();
        Array.Reverse(vetor);
        Console.WriteLine("Vetor invertido: " + new string(vetor));
    }

    
    // Exercício 10 – Lançamento de dados
    static void Exercicio10()
    {
        Console.Write("Informe N lançamentos: ");
        int n = int.Parse(Console.ReadLine());
        int[] lancamentos = new int[n];
        int[] ocorrencias = new int[6];

        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            lancamentos[i] = rnd.Next(1, 7);
            ocorrencias[lancamentos[i] - 1]++;
        }

        Console.WriteLine("Ocorrências de cada face:");
        for (int i = 0; i < 6; i++)
            Console.WriteLine($"{i + 1}: {ocorrencias[i]}");
    }

    
    // Exercício 11 – Língua do P
    static void Exercicio11()
    {
        Console.WriteLine("Digite a mensagem codificada na língua do P:");
        string msg = Console.ReadLine();
        string decodificada = "";
        for (int i = 0; i < msg.Length; i++)
        {
            if (msg[i] == 'p' && i + 1 < msg.Length && char.IsLetter(msg[i + 1]))
            {
                i++; // pula o 'p' antes da letra
            }
            decodificada += msg[i];
        }
        Console.WriteLine("Mensagem decodificada: " + decodificada);
    }

    
    // Exercício 12 – Carnaval
    static void Exercicio12()
    {
        Console.WriteLine("Digite 5 notas (separadas por espaço):");
        string[] input = Console.ReadLine().Split();
        double[] notas = Array.ConvertAll(input, double.Parse);
        Array.Sort(notas);
        double notaFinal = notas[1] + notas[2] + notas[3];
        Console.WriteLine($"Nota final: {notaFinal:F1}");
    }

    // ===Menu
    static void Main()
    {
        Console.WriteLine("Qual exercício você quer testar? (1-12)");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1: Exercicio1(); break;
            case 2: Exercicio2(); break;
            case 3: Exercicio3(); break;
            case 4: Exercicio4(); break;
            case 5: Exercicio5(); break;
            case 6: Exercicio6(); break;
            case 7: Exercicio7(); break;
            case 8: Exercicio8(); break;
            case 9: Exercicio9(); break;
            case 10: Exercicio10(); break;
            case 11: Exercicio11(); break;
            case 12: Exercicio12(); break;
            default: Console.WriteLine("Exercício inválido!"); break;
        }
    }
}

