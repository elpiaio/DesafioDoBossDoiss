using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace DesafioDoBossDoiss
{
    public class ExerciciosFacill
    {
        public static void Exercicio0() //programa em C# que imprima todos os números de 1 a 10 usando um loop for. 
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() // programa em C# que imprima todos os números pares entre 1 e 20 usando um loop for.
        {
            try
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() // programa que multiplique todos os números em um array de 5 elementos usando um loop for.
        {
            try
            {
                Console.WriteLine("Digite 5 números para serem multiplicados separados por vírgula");
                var input = Console.ReadLine();
                var numerosString = input.Split(',');

                List<decimal> numeros = new List<decimal>();
                
                foreach (var numeroString in numerosString)
                {
                    var bct = numeroString.Replace(" ","");
                    numeros.Add(Decimal.Parse(bct));
                }
                
                decimal result = 1;
                for (int i = 0; i < numeros.Count; i++)
                {
                    result = result * numeros[i];
                }
                Console.WriteLine(result);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() // programa que peça ao usuário para digitar 10 números e, em seguida, use um loop for para somar todos eles e imprimir o resultado.
        {
            try
            {
                Console.WriteLine("Digite 10 números para serem somados separados por vírgula");
                var input = Console.ReadLine();
                var numerosString = input.Split(',');
                List<decimal> numeros = new List<decimal>();

                foreach (var numeroString in numerosString)
                {
                    var bct = numeroString.Replace(" ", "");
                    numeros.Add(Decimal.Parse(bct));
                }

                decimal result = 0;
                for (int i = 0; i < numeros.Count; i++)
                {
                    result = result + numeros[i];
                }
                Console.WriteLine(result);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() // programa em C# que imprima a tabuada de qualquer número escolhido pelo usuário utilizando o loop for.
        {
            try
            {
                Console.WriteLine("Digite um número para descobrir a tabuada dele");
                var number = Convert.ToDecimal(Console.ReadLine());
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{number} X {i} == {number * i}");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() // programa que imprima todos os elementos de uma lista de strings utilizando um loop foreach.
        {
            try
            {
                List<string> list = new List<string>() {"nego(não posso zoar)","willian cabeça de bagre","vine só faz gol cagado","neemias quero meu salário" };
                foreach ( string elemento in list)
                {
                    Console.WriteLine(elemento);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() //  programa que peça ao usuário para digitar 5 nomes. Armazene esses nomes em uma lista e use um loop foreach para imprimir todos os nomes.
        {
            try
            {
                Console.WriteLine("digite 5 nomes divididos por virgula");
                string input = Console.ReadLine().Trim();
                List<string> list = new List<string>() { };
                list.AddRange(input.Split(','));

                foreach (string elemento in list)
                {
                    Console.WriteLine(elemento);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() //programa em C# que imprima os números ímpares entre 1 e 10 usando um loop foreach em uma lista.
        {
            try
            {
                for (int i = 1; i < 11 ; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() // programa que multiplique todos os números em um array de 5 elementos usando um loop foreach.
        {
            try
            {
                Console.WriteLine("Digite 5 números para serem multiplicados separados por vírgula");
                var input = Console.ReadLine();
                var numerosString = input.Split(',');

                List<decimal> numeros = new List<decimal>();

                foreach (var numeroString in numerosString)
                {
                    var bct = numeroString.Replace(" ", "");
                    numeros.Add(Decimal.Parse(bct));
                }
                decimal result = 1;

                foreach (var numero in numeros)
                {
                    result = numero * result;
                }
                Console.WriteLine(result);

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() // programa que peça ao usuário para digitar vários nomes até que ele digite "pare". Em seguida, use um loop foreach para imprimir todos os nomes.
        {
            try
            {
                List<string> list = new List<string>();
                string validacao = "";
                
                Console.WriteLine("digite nome e precione enter, ou digite [pare] para parar o sistema: ");
                while (validacao != "pare")
                {
                    validacao = Console.ReadLine().Trim();

                    if (validacao != "pare")
                    {
                        list.Add(validacao);
                        validacao = "";
                    }
                    else
                    {
                        foreach (var element in list)
                        {
                            Console.WriteLine("-------" + element);

                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}