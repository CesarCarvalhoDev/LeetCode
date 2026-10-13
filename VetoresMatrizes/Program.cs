public class Program
{
    // ==========================================================================================================================================
    // Exercício 1: Maior e Menor Elemento de um Vetor
    // Enunciado: Escreve um método em C# que receba um vetor de números inteiros não vazio e retorne o maior e o menor valor presentes no vetor.
    // Entrada de exemplo:
    // int[] numeros = [14, 2, 85, 33, 7];
    // Saída esperada:
    // Maior: 85, Menor: 2
    // ==========================================================================================================================================
    public static int[] MaiorMenor(int[] numeros)
    {
        int maior = 0;
        int menor = 0;
        for(var i = 0; i < numeros.Length; i++)
        {
            if(i == 0)
            {
                menor = numeros[i];
            }
            if(numeros[i] > maior)
            {
                maior = numeros[i];
            }
            else if(numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        return [maior, menor];
    }

    // ==========================================================================================================================================
    // Exercício 2: Inversão de Vetor no Próprio Espaço (In-place)
    // Enunciado: Dado um vetor de números inteiros, inverte a ordem dos seus elementos sem recorrer a um vetor auxiliar (complexidade de espaço adicional $O(1)$).
    // Entrada de exemplo:int[] arr = [1, 2, 3, 4, 5];Saída esperada:[5, 4, 3, 2, 1]
    // ==========================================================================================================================================
    public static int[] InverterVetor(int[] numeros)
    {   
        var x = 0;
        var fimVetor = numeros.Length -1;
        for(var i = 0; i < numeros.Length / 2; i++)
        {
            x = numeros[i];
            numeros[i] = numeros[fimVetor];
            numeros[fimVetor] = x;
            fimVetor--;
        }
        return numeros;
    }

    // ==========================================================================================================================================
    //Exercício 3: Contagem de Números Pares e Ímpares
    //Enunciado: Dado um vetor de números inteiros, percorre a coleção e determina a quantidade total de valores pares e de valores ímpares.
    // Entrada de exemplo:
    // int[] valores = [3, 8, 12, 5, 9, 2, 4];
    // Saída esperada:
    // Pares: 4, Ímpares: 3
    // ==========================================================================================================================================

    public static int[] ContarParImpar(int[] numeros)
    {
        var pares = 0; 
        var impares = 0;

        for(var i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] % 2 == 0)
            {
                pares++;
            } else
            {
              impares++;  
            }
        }
        return [pares,impares];
    }
    // ==========================================================================================================================================
    // Exercício 4: Soma da Diagonal Principal de uma Matriz Quadrada
    // Enunciado: Dada uma matriz bidimensional quadrada (N X N) de inteiros, calcula a soma de todos os elementos que compõem a sua diagonal principal (índices onde linha == coluna).
    // Entrada de exemplo:C#int[,] matriz = new int[3, 3]
    // {
    //     { 1, 2, 3 },
    //     { 4, 5, 6 },
    //     { 7, 8, 9 }
    // };
    // Saída esperada: 15 (Cálculo: $1 + 5 + 9 = 15)
    // ==========================================================================================================================================
    public static int CalcularSomaDiagonal(int[,] matriz)
    {
        var soma = 0;
        for(var i = 0; i < matriz.GetLength(0); i++)
        {
            for(var j = 0; j < matriz.GetLength(1); j++)
            {
                if(i == j)
                {
                    soma = soma + matriz[i,j];
                }
            }
        }
        return soma;
    }
    // ==========================================================================================================================================
    // Exercício 5: Soma por Linha de uma Matriz
    // Enunciado: Dada uma matriz bidimensional de dimensões M X N, calcula a soma dos elementos de cada linha e armazena os resultados num novo vetor unidimensional de tamanho M.
    // Entrada de exemplo:
    // int[,] grelha = new int[2, 3]
    // {
    //     { 1, 2, 3 },
    //     { 4, 5, 6 }
    // };
    // Saída esperada:[6, 15]
    // ==========================================================================================================================================

    public static int[] CalcularSomaLinha(int[,] grelha)
    {
        int[] somaLinhas = new int[2];
        for(var i = 0; i < grelha.GetLength(0); i++)
        {
            for(var j = 0; j < grelha.GetLength(1); j++)
            {
                somaLinhas[i] = somaLinhas[i] + grelha[i,j];
            }
        }
        return somaLinhas;
    }
    static void Main(string[] args)
    {   
        Console.WriteLine("Exercicio 1");
        var res1 = MaiorMenor([14, 2, 85, 33, 7]);
        Console.WriteLine("Maior: " + res1[0] + " Menor: " + res1[1]);
        Console.WriteLine("Exercicio 2");
        Console.WriteLine(string.Join(", ",InverterVetor([1,2,3,4,5,6,7,8])));
        Console.WriteLine("Exercicio 3");
        Console.WriteLine(string.Join(", ",ContarParImpar([3, 8, 12, 5, 9, 2, 4])));
        Console.WriteLine("Exercicio 4");
        var matriz = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine(CalcularSomaDiagonal(matriz));
        Console.WriteLine("Exercicio 5");
        int[,] grelha = new int[2, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
         Console.WriteLine(string.Join(", ",CalcularSomaLinha(grelha)));
    }
} 