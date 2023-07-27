using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDoBossDoiss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeticao = "r";
            while (repeticao == "r")
            {
                List<string> listdesafiosbasicos = new List<string>()
                {
                    "Escreva um programa em C# que imprima todos os números de 1 a 10 usando um loop for.",
                    "Escreva um programa em C# que imprima todos os números pares entre 1 e 20 usando um loop for.",
                    "Crie um programa que multiplique todos os números em um array de 5 elementos usando um loop for.",
                    "Escreva um programa que peça ao usuário para digitar 10 números e, em seguida, use um loop for para somar todos eles e imprimir o resultado.",
                    "Crie um programa em C# que imprima a tabuada de qualquer número escolhido pelo usuário utilizando o loop for.",
                    "Crie um programa que imprima todos os elementos de uma lista de strings utilizando um loop foreach.",
                    "Faça um programa que peça ao usuário para digitar 5 nomes. Armazene esses nomes em uma lista e use um loop foreach para imprimir todos os nomes.",
                    "Escreva um programa em C# que imprima os números ímpares entre 1 e 10 usando um loop foreach em uma lista.",
                    "Crie um programa que multiplique todos os números em um array de 5 elementos usando um loop foreach.",
                    "Crie um programa que peça ao usuário para digitar vários nomes até que ele digite \"pare\". Em seguida, use um loop foreach para imprimir todos os nomes."
                };
                List<string> listdesafiosintermediarios = new List<string>() 
                {
                "Crie um programa que leia uma matriz de 10x10 e imprima todos os seus elementos usando loops for aninhados.",
                "Escreva um programa que calcule a soma dos números em uma matriz 2D usando loops for aninhados.",
                "Crie um programa que peça ao usuário para inserir 5 nomes e 5 idades correspondentes. Em seguida, use um loop foreach para imprimir o nome e a idade de cada pessoa.",
                "Escreva um programa em C# que some todos os números ímpares em uma lista usando um loop foreach.",
                "Crie um programa que peça ao usuário para digitar um número n e depois use um loop for para calcular o fatorial de n.",
                "Escreva um programa que inverta uma string usando um loop for.",
                "Crie um programa que leia uma lista de números do usuário e imprima o menor e o maior número da lista usando loops for ou foreach.",
                "Faça um programa que leia uma string e conte o número de vogais na string usando um loop foreach.",
                "Crie um programa que peça ao usuário para digitar um número n e então imprima a sequência de Fibonacci até o n-ésimo termo usando um loop for.",
                "Escreva um programa que leia uma string e a imprima em ordem reversa usando um loop foreach.",
                };
                List<string> listdesafiosdificeis = new List<string>() 
                {
                "Crie um programa que ordena um array de números usando o algoritmo de ordenação de bolha com um loop for.",
                "Escreva um programa que encontre o caminho mais curto em um labirinto usando o algoritmo de busca em profundidade e um loop for.",
                "Faça um programa que peça ao usuário para inserir uma série de números e então use um loop for para encontrar todos os números primos na série.",
                "Escreva um programa que leia uma string e imprima o número de palavras na string usando um loop foreach.",
                "Crie um programa que calcule a média, a variância e o desvio padrão de uma lista de números usando loops for.",
                "Faça um programa que leia uma string e a imprima sem espaços usando um loop foreach.",
                "Escreva um programa em C# que leia uma lista de números e imprima a soma dos números pares e a soma dos números ímpares usando um loop for.",
                "Crie um programa que leia um número n e imprima o n-ésimo número primo usando um loop for.",
                "Faça um programa que leia uma string e conte o número de cada letra na string usando um loop foreach.",
                "Escreva um programa em C# que leia um texto e encontre a palavra mais frequente no texto usando um loop foreach."

                };

                Console.WriteLine("----------------------\nbem vindo ao Desafio máximo do Nego!!!!\n---------------------- \ndigite o numero correspondente para escolher uma opção:\n\n");
                Console.WriteLine("Escolha o tipo de desafio\n--------------\n1 = facil\n2 = medio\n3 = dificil");

                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        while (repeticao == "r")
                        {
                            for (int i = 0; i < listdesafiosbasicos.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosbasicos[i]);
                            }
                            ExerciciosFacilEscolha();


                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    case "2":
                        while (repeticao == "r")
                        {
                            for (int i = 0; i < listdesafiosintermediarios.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosintermediarios[i]);
                            }
                            ExerciciosIntermediarioEscolha();

                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    case "3":
                        while (repeticao == "r")
                        {
                            for (int i = 0; i < listdesafiosdificeis.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosdificeis[i]);
                            }
                            ExerciciosAvancadosEscolha();


                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    default:

                        break;
                }

                Console.WriteLine("Digite [r] para repetir a escolha do nivel ou qualquer outra letra para finalizar");
                repeticao = Console.ReadLine();
                Console.Clear();
            }
        }
        public static void ExerciciosFacilEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosFacill.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosFacill.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosFacill.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosFacill.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosFacill.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosFacill.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosFacill.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosFacill.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosFacill.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosFacill.Exercicio9();
            }
        }
        public static void ExerciciosIntermediarioEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosIntermediario.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosIntermediario.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosIntermediario.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosIntermediario.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosIntermediario.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosIntermediario.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosIntermediario.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosIntermediario.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosIntermediario.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosIntermediario.Exercicio9();
            }
        }
        public static void ExerciciosAvancadosEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosAvancados.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosAvancados.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosAvancados.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosAvancados.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosAvancados.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosAvancados.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosAvancados.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosAvancados.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosAvancados.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosAvancados.Exercicio9();
            }
        }
    }
}
