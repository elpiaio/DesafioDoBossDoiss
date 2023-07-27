using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDoBossDoiss
{
    internal class ExerciciosIntermediario
    {
        public static void Exercicio0() // programa que leia uma matriz de 10x10 e imprima todos os seus elementos usando loops for aninhados.
        {
            try
            {
                int[,] matriz = new int[,]
                {
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
                };


                Console.WriteLine("\nElementos da matriz:");
                for (int linha = 0; linha < 10; linha++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        Console.Write(matriz[linha, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() // programa que calcule a soma dos números em uma matriz 2D usando loops for aninhados.
        {
            try
            {
                int[,] matriz = new int[,]
                {
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 }
                };

                int result = 0;
                for (int linha = 0; linha < 2; linha++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        result = result + matriz[linha, col];
                    }
                }
                Console.WriteLine(result);

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() // programa que peça ao usuário para inserir 5 nomes e 5 idades correspondentes. Em seguida, use um loop foreach para imprimir o nome e a idade de cada pessoa.
        {
            try
            {
                List<string> nomes = new List<string>() {"PEDRO", "THIAGO", "JOÃO","NO BARQUINHO"};
                List<string> idades = new List<string>() {"20","17","23","2000" };

                int i = 0;
                foreach (var nome in nomes)
                {
                    Console.WriteLine(nomes + " ---- " + idades[i]);
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() // um programa em C# que some todos os números ímpares em uma lista usando um loop foreach.
        {
            try
            {
                List<decimal> numeros = new List<decimal>() {6,7,8,9,5,4,3,2,1 };
                decimal result = 0;

                foreach (var numero in numeros)
                {
                    if (numero % 2 != 0)
                    {
                        result = numero + result;
                    }
                }
                Console.WriteLine(result);

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() //  programa que peça ao usuário para digitar um número n e depois use um loop for para calcular o fatorial de n.
        {
            try
            {
                Console.WriteLine("digite um numero para fatorar");
                int n = Int32.Parse(Console.ReadLine());
                List<int> numeros = new List<int>();
                for(int i = 2; n > 1; i++)
                {
                    if(n % i == 0)
                    {
                        while(n % i == 0)
                        {
                            numeros.Add(n);
                            Console.WriteLine($"{n} | {i}");
                            n = n / i;
                        }
                    }
                }
                Console.WriteLine("1 |");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() //  programa que inverta uma string usando um loop for.
        {
            try
            {
                Console.WriteLine("Digite alguma coisa");
                string aaa = Console.ReadLine();
                string nova = "";
                
                for (int i = aaa.Length -1; i != 0; i--)
                {
                    nova = nova + aaa.Substring(i, 1);
                }
                nova =  nova + aaa.Substring(0, 1) ;
                Console.WriteLine(nova);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() // programa que leia uma lista de números do usuário e imprima o menor e o maior número da lista usando loops for ou foreach.
        {
            try
            {
                Console.WriteLine("Digite números para serem comparados separados por vírgula");
                var input = Console.ReadLine();
                var numerosString = input.Split(',');

                List<decimal> numeros = new List<decimal>();

                foreach (var numeroString in numerosString)
                {
                    var num = numeroString.Replace(" ", "");
                    numeros.Add(Decimal.Parse(num));
                }

                decimal fixoMaior = 0;
                decimal fixoMenor = 0;
                for (int i = 0; i < numeros.Count; i++)
                {
                    if (fixoMaior < numeros[i])
                    {
                        fixoMaior = numeros[i];
                    }
                }
                Console.WriteLine(fixoMaior);
                fixoMenor = fixoMaior;
                foreach(var num in numeros)
                {
                    if (fixoMenor > num)
                    {
                        fixoMenor = num;
                    }
                }
                Console.WriteLine(fixoMenor);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() //  programa que leia uma string e conte o número de vogais na string usando um loop foreach.
        {
            try
            {
                Console.WriteLine("Digite alguma coisa");
                string frase = Console.ReadLine().Trim().ToLower();
                string aeiou = "aeiou";
                int contador = 0;
                for (int i = 0; i<frase.Length; i++)
                {
                    foreach (var letter in frase.Substring(i,1))
                    {
                        if (letter == aeiou[0]) { contador++; }
                        if (letter == aeiou[1]) { contador++; }
                        if (letter == aeiou[2]) { contador++; }
                        if (letter == aeiou[3]) { contador++; }
                        if (letter == aeiou[4]) { contador++; }
                    }
                }
                Console.WriteLine(contador);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() // programa que peça ao usuário para digitar um número n e então imprima a sequência de Fibonacci até o n-ésimo termo usando um loop for.
        {
            try
            {
                Console.WriteLine("Digite o enésimo termo");
                int n = Convert.ToInt32(Console.ReadLine());
                
                int n1 = 1;
                int n2 = 0;
                int soma = 0;
                Console.WriteLine("sequencia de fibonacci: 1");
                
                for (var i = 1; i <= n-1; i++)
                {
                    soma = n1 + n2;
                    n2 = n1;
                    n1 = soma;

                    Console.WriteLine("sequencia de fibonacci: " + soma);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() // programa que leia uma string e a imprima em ordem reversa usando um loop foreach.
        {
            try
            {
                Console.WriteLine("Digite alguma coisa");
                string aaa = Console.ReadLine();
                var char_string = aaa.ToCharArray();
                string nova = "";

                foreach (var letter in char_string)
                {
                    nova = letter + nova;
                }
                Console.WriteLine(nova);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
