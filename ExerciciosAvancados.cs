using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDoBossDoiss
{
    internal class ExerciciosAvancados
    {
        public static void Exercicio0() // programa que ordena um array de números usando o algoritmo de ordenação de bolha com um loop for.
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

                for (int i = 0; i < numeros.Count(); i++)
                {
                    for (int j = 0; j < (numeros.Count() - i - 1); j++)
                    {
                        if (numeros[j] > numeros[j + 1])
                        {
                            var temp = numeros[j];
                            numeros[j] = numeros[j + 1];
                            numeros[j + 1] = temp;
                        }
                    }
                }
                foreach (var num in numeros)
                {
                    Console.Write(num + ",");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() //  programa que encontre o caminho mais curto em um labirinto usando o algoritmo de busca em profundidade e um loop for
        {
            try
            {
                int[,] labirinto = new int[,]
{
                { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 2, 1, 1, 0, 0, 0, 0, 0, 0 }
            };

                int linha = 0;
                int coluna = 0;
                int soma = 1;
                List<int> list_linha_um = new List <int>();
                List<int> list_coluna_um = new List<int>();

                for (linha = 0; linha < 10; linha++)
                {
                    for (coluna = 0; coluna < 10; coluna++)
                    {
                        if (labirinto[linha, coluna] == 2)
                        {
                            Console.WriteLine("VC CHEGOU");
                            return;
                        }
                        if (labirinto[linha, coluna] == 1)
                        {
                            if (linha + coluna == soma)
                            {
                                list_linha_um.Add(linha);
                                list_coluna_um.Add(coluna);
                                Console.WriteLine($"linha: {linha} e coluna: {coluna}");
                                soma++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() // programa que peça ao usuário para inserir uma série de números e então use um loop for para encontrar todos os números primos na série.
        {
            try
            {
                Console.WriteLine("Digite números para serem analisados separados por vírgula");
                var input = Console.ReadLine();
                var numerosString = input.Split(',');

                List<decimal> numeros = new List<decimal>();

                foreach (var numeroString in numerosString)
                {
                    var num = numeroString.Replace(" ", "");
                    numeros.Add(Decimal.Parse(num));
                }
                bool primo = true;
                for (int i = 0; i < numeros.Count; i++)
                {
                    for (int j = 2; j <= numeros[i] / 2; j++)
                    {
                        if (numeros[i] % j == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                    if (primo && numeros[i] > 1)
                    {
                        Console.WriteLine(numeros[i]);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() // programa que leia uma string e imprima o número de palavras na string usando um loop foreach.
        {
            try
            {
                Console.WriteLine("digite alguma coisa: ");
                var input = Console.ReadLine();

                int contador = 0;
                string[] palavras = input.Split(' ');

                foreach (var palavra in palavras)
                {
                    contador++;
                }
                Console.WriteLine(contador);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() // programa que calcule a média, a variância e o desvio padrão de uma lista de números usando loops for. 
        {
            try
            {
                Console.WriteLine("Digite 5 números para serem analisados separados por vírgula");
                var input = Console.ReadLine();
                var numerosString = input.Split(',');

                List<decimal> numeros = new List<decimal>();

                foreach (var numeroString in numerosString)
                {
                    var num = numeroString.Replace(" ", "");
                    numeros.Add(Decimal.Parse(num));
                }


                if (numeros.Count == 4)
                {
                    decimal media = 0;
                    media = (numeros[0] + numeros[1] + numeros[2] + numeros[3] /*+ numeros[4]*/) / 4;
                    Console.WriteLine("media: " + media);

                    decimal dm0 = numeros[0] - media;
                    decimal dm1 = numeros[1] - media;
                    decimal dm2 = numeros[2] - media;
                    decimal dm3 = numeros[3] - media;
                    /* decimal dm4 = numeros[4] - media;*/

                    decimal variancia = ((dm0 * dm0) + (dm1 * dm1) + (dm2 * dm2) + (dm3 * dm3) /*+ (dm4 * dm4)*/) / 4;
                    Console.WriteLine("variancia: " + variancia);
                    Console.WriteLine("desvio padrao: " + Math.Sqrt(Convert.ToDouble(variancia)));

                }
                else
                {
                    Console.WriteLine("VOCE NAO DIGITOU 5 TERMOS");
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() // programa que leia uma string e a imprima sem espaços usando um loop foreach.
        {
            try
            {
                string nova = "";
                Console.WriteLine("digite uma frase");
                string blablabla = Console.ReadLine();
                List<string> list = new List<string>(blablabla.Split(' '));

                foreach (string word in list)
                {
                    Console.Write(word);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() //  programa em C# que leia uma lista de números e imprima a soma dos números pares e a soma dos números ímpares usando um loop for
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

                List<decimal> numerosPares = new List<decimal>();
                List<decimal> numerosImpares = new List<decimal>();

                for (int i = 0; i < numeros.Count(); i++)
                {
                    if (numeros[i] % 2 == 0)
                    {
                        numerosPares.Add(numeros[i]);
                    }
                    else
                    {
                        numerosImpares.Add(numeros[i]);
                    }
                }
                Console.WriteLine("------------\nnumeros pares");
                foreach (var num in numerosPares)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("------------\nnumeros impares");
                foreach (var num in numerosImpares)
                {
                    Console.WriteLine(num);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() // programa que leia um número n e imprima o n-ésimo número primo usando um loop for.",
        {
            try
            {
                Console.WriteLine("Digite o enésimo termo dos nmrs primos");
                int n = Convert.ToInt32(Console.ReadLine());

                var div = 0;
                int j = 1;

                for (int number = 0; j <= n; number++)
                {
                    div = 0;
                    for (int i = 2; i <= number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            div++;
                        }
                    }

                    if (div == 0)
                    {

                        Console.WriteLine(j + "º - " + number);
                        j++;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() // programa que leia uma string e conte o número de cada letra na string usando um loop foreach 
        {
            try
            {
                Console.Write("Digite uma frase: ");
                string input = Console.ReadLine();

                Dictionary<char, int> Contagem_da_letra = new Dictionary<char, int>();

                foreach (char letter in input)
                {
                    // Ignora caracteres não alfabéticos
                    if (char.IsLetter(letter))
                    {
                        if (Contagem_da_letra.ContainsKey(letter))
                        {
                            Contagem_da_letra[letter]++;
                        }
                        else
                        {
                            Contagem_da_letra[letter] = 1;
                        }
                    }
                }
                Console.WriteLine("Contagem de letras na string:");
                foreach (var par in Contagem_da_letra)
                {
                    Console.WriteLine($"{par.Key}: {par.Value}");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() // programa em C# que leia um texto e encontre a palavra mais frequente no texto usando um loop foreach 
        {
            try
            {
                Console.WriteLine("Digite o texto:");
                string input = Console.ReadLine();
                string[] palavras = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries); 

                Dictionary<string, int> frequencia = new Dictionary<string, int>();

                foreach (string palavra in palavras)
                {
                    string palavra_tolower = palavra.ToLower();

                    if (frequencia.ContainsKey(palavra_tolower))
                    {
                        frequencia[palavra_tolower]++;
                    }
                    else
                    {
                        frequencia[palavra_tolower] = 1;
                    }
                }

                string palavra_fodona = "";
                int numero = 0;

                foreach (var par in frequencia)
                {
                    if (par.Value > numero)
                    {
                        palavra_fodona = par.Key;
                        numero = par.Value;
                    }
                }

                Console.WriteLine($"A palavra mais frequente no texto é '{palavra_fodona}' com {numero} ocorrências.");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
