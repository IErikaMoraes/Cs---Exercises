using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace at29nov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1: Solicite dois números ao usuário. Calcule a soma dos números.
            //Se a soma for ímpar, exiba "Número é Ímpar".

            Console.Write("Informe o primeiro numero para somar: ");
            int numero1 = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o segundo numero para somar: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            if (soma % 2 != 0) // módulo para achar o numero PAR, diferente de 0 é ÍMPAR.
            {
                Console.WriteLine("Número é ímpar.");
            }


            //Exercício 2: Solicite dois números ao usuário para divisão. 
            //Calcule e exiba o resultado da divisão arredondado para 3 casas decimais.

            Console.WriteLine("______________________________________________");
            Console.Write("Informe o Dividendo: ");
            double dividendo = double.Parse(Console.ReadLine());
            
            Console.Write("Informe o Divisor: ");
            double divisor = double.Parse(Console.ReadLine());

            if (divisor != 0)
            {
                double divisao = dividendo / divisor;

                Console.WriteLine("Resultado da divisão: " + Math.Round(divisao, 3));
            }
            else
            {
                Console.WriteLine("Erro: Divisão impossível, divisor = 0!!!");
            }


            //Exercício 3: Solicite um número ao usuário.
            //Se o número for maior que 10, emita um sinal sonoro e exiba "Erro, valor maior do que o aceitável".
            //Caso contrário, calcule o resultado multiplicando o número por π(3.14) e exiba.

            Console.WriteLine("______________________________________________");
            Console.Write("Informe um número para multiplicar por PI: ");
            double numero3 = double.Parse(Console.ReadLine());

            if (numero3 > 10)
            {
                Console.WriteLine("Erro, valor maior do que o aceitável!");
                Console.Beep();
            }
            else
            {
                Console.WriteLine("Resultado: " + (numero3 * Math.PI));
            }


            //Exercício 4: Exiba os primeiros 10 números naturais.

            Console.WriteLine("______________________________________________");
            Console.Write("Números naturais: ");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }


            //Exercício 5: Exiba os primeiros 10 números naturais. Calcule e exiba a soma desses números.

            Console.WriteLine("______________________________________________");
            int somaNumNat = 0;

            Console.Write("Números naturais: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                somaNumNat = somaNumNat + i;  //OU somaNumNat += i;
            }
            Console.WriteLine("Soma números naturais acima: " + somaNumNat);


            //Exercício 6: Solicite ao usuário o número de termos.
            //Calcule e exiba a soma dos números naturais até o número de termos especificado.

            Console.WriteLine("______________________________________________");
            Console.Write("Insira o número de Termos desejados: ");
            int termoUser = int.Parse(Console.ReadLine());
            int somaTermos = 0;

            for (int i = 1; i <= termoUser; i++)
            {
                somaTermos = somaTermos + i;
            }
            Console.WriteLine("Soma Total dos termos até o Termo inserido: " + somaTermos);


            //Exercício 7: Exiba os 10 números naturais ao usuário.
            //Calcule e exiba a soma e a média desses números.

            Console.WriteLine("______________________________________________");
            int somaNumNat2 = 0;
            int cont = 0;
            double media;

            Console.WriteLine("Números naturais: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                somaNumNat2 = somaNumNat2 + i;
                cont++;
            }
            Console.WriteLine("Soma dos números naturais acima: " + somaNumNat2);

            media = somaNumNat2 / cont;
            Console.WriteLine("Média dos números naturais acima: " + media);


            //Exercício 8: Solicite ao usuário o número de termos.
            //Exiba os números e seus cubos até o número de termos especificado.

            Console.WriteLine("______________________________________________");
            Console.Write("Insira o número de Termos desejados para cálculo do Cubo: ");
            int termoUser2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= termoUser2; i++)
            {
                Console.WriteLine("Termo: " + i + ", Cubo do Termo: " + (i * i * i));
                // OU
                Console.WriteLine($"Com Biblioteca Math.Pow: {Math.Pow(i, 3)}");
            }


            //Exercício 9:Solicite ao usuário o número de termos.
            //Utilizando uma função, exiba os cubos dos números até o número de termos especificado.

            Console.WriteLine("______________________________________________");
            Console.Write("Insira o número de Termos desejados para cálculo do Cubo com FUNÇÃO: ");
            int termoUser3 = int.Parse(Console.ReadLine());
                        
            Cubo(termoUser);


            //Exercício 10 - Jogo de Adivinhação: Gere aleatoriamente um número entre 1 e 100.
            //Peça ao usuário para adivinhar o número. Forneça dicas(maior ou menor) até que o usuário acerte.

            Console.WriteLine("______________________________________________");
            Console.WriteLine("***** Jogo de Adivinhação *****");
            Console.Write("Tente adivinhar um número entre 1 e 100.");

            //Função que gera um número aleatório entre 1 e 100
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);

            //criação e atribuição de variáves de controle
            int tentativa;
            int contadorTentativas = 0;

            do
            {
                Console.Write("Digite sua tentativa: ");
                string inputUser = Console.ReadLine();

                if (int.TryParse(inputUser, out tentativa))  //tentativa variável declarada antes do bloco do-while para que seja acessível fora desse bloco.
                {
                    contadorTentativas++;

                    if (tentativa < numeroAleatorio)
                    {
                        Console.WriteLine("Tente novamente. O número é maior.");
                    }
                    else if (tentativa > numeroAleatorio)
                    {
                        Console.WriteLine("Tente novamente. O número é menor.");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns! Você acertou em {contadorTentativas} tentativas. O número era {numeroAleatorio}.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }
            } while (tentativa != numeroAleatorio && contadorTentativas <4);


            //Exercício 11 - Conversor de Moeda:
            //Solicite ao usuário que insira uma quantidade em Reais.
            //Converta essa quantia para Euros usando uma taxa de câmbio fixa. Exiba o valor em Euros.

            Console.WriteLine("______________________________________________");
            Console.WriteLine("***** Conversão de Câmbios *****");
            Console.Write("Insira o valor na moeda Real para conversão cambial: ");

            // Console.ReadLine() uma vez para obter/ler a entrada/input do usuário, por padrão lê strings.
            string inputUsuario = Console.ReadLine();

            // Use double.TryParse para validar a entrada do usuário e converter para double
            if (double.TryParse(inputUsuario, out double valorReal))  // valorReal é declarada e inicializada na mesma linha em que é passada como argumento para o método TryParse. //declaração de variável local em linha (local variable declaration in-line). O escopo da variável valorReal está limitado ao bloco condicional onde é usada.
            {
                double cambioEuro = 0.19;
                double valorEuro = valorReal * cambioEuro;

                Console.WriteLine($"Valor em Euro: {valorEuro:F2}€");
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }


            //Exercício 12 - Tabuada:
            //Peça ao usuário para inserir um número. Exiba a tabuada desse número de 1 a 10.

            Console.WriteLine("______________________________________________");
            Console.WriteLine("***** Tabuada *****");
            Console.Write("Insira o valor da Tabuada que deseja: ");
            int tabuada = int.Parse(Console.ReadLine());

            Tabuada1(tabuada);


            //Exercício 13 - Calculadora de IMC(Índice de Massa Corporal):
            //Peça ao usuário para inserir seu peso(em kg) e altura(em metros).
            //Calcule o IMC usando a fórmula: IMC = peso / (altura * altura).Exiba o IMC

            Console.WriteLine("______________________________________________");
            Console.WriteLine("***** Calculadora de IMC *****");

            // Solicita o peso do usuário
            Console.Write("Insira o seu peso (em kg): ");
            if (double.TryParse(Console.ReadLine(), out double peso))  //peso é variável declarada e inicializada na mesma linha em que é passada como argumento para o método TryParse para conversão.
            {
                // Solicita a altura do usuário
                Console.Write("Insira a sua altura (em metros): ");
                if (double.TryParse(Console.ReadLine(), out double altura))
                {
                    // Calcula o IMC
                    double imc = peso / (altura * altura);

                    // Exibe o resultado
                    Console.WriteLine($"O seu IMC é: {imc:F2}");  //:F2 = precisão de duas casas decimais. Formatação de string que controla como um número de ponto flutuante (float ou double) é exibido. 
                }
                else
                {
                    Console.WriteLine("Por favor, insira uma altura válida.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um peso válido.");
            }


            //EXERCÍCIOS NÃO OBRIGATÓRIOS: 

            //Exercício 14 - Verificador de Números Primos:
            //Peça ao usuário para inserir um número. Verifique se o número é primo ou não e exiba o resultado.

            //Os números primos SÃO números naturais maiores que 1 que têm apenas dois divisores positivos: 1 e o próprio número.
            //(números menores ou iguais a 1 (<=1) NÃO SÃO primos).
            //(2 é o menor número primo).
            //(numeros primos: 3,5,7,11,13,17,19...)
            //Em outras palavras, um número primo é um número que NÃO PODE ser obtido multiplicando dois números inteiros positivos DIFERENTES de: 1 e do próprio número.
            //Se n não for primo, ele terá pelo menos um par de fatores a e b, onde ambos os fatores são menores ou iguais à raiz quadrada de n (<=raizQuadrada n).

            Console.WriteLine("______________________________________________");
            Console.WriteLine("Verificador de Números Primos");
            Console.Write("Digite um número: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (VerificaPrimo(numero))
                {
                    Console.WriteLine($"O número {numero} é primo.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} não é primo.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

            static bool VerificaPrimo(int num)
            {
                //Se n for menor ou igual a 1, retorna false (números menores ou iguais a 1 não são primos).
                if (num <= 1)  
                {
                    return false;
                }

                //Usa um loop for para verificar divisores de 2 até a raiz quadrada de n, ou seja, continua o loop enquanto i é menor a ou igual à raiz quadrada de n.
                //Se encontrar um divisor, retorna false; caso contrário, retorna true.
                for (int i = 2; i <= Math.Sqrt(num); i++)  //função em C# que calcula a raiz quadrada de um número. A palavra "Sqrt" é uma abreviação de "Square Root" (raiz quadrada em inglês).
                {
                    //Verifica se i é um divisor de n.
                    //Se n for divisível por i, isso significa que n não é primo, e a função retorna false.
                    if (num % i == 0)  
                    {
                        return false;
                    }
                }
                return true;
            }

            //Exercício 15 - Calculadora de Fatorial:
            //Peça ao usuário para inserir um número. Calcule o fatorial desse número e exiba o resultado.

            //Fatorial de um número inteiro não negativo n, representado por n!, é o produto de todos os números inteiros positivos menores ou iguais a n.

            Console.WriteLine("______________________________________________");
            Console.WriteLine("Calculadora de Fatorial");
            Console.Write("Digite um número para calcular o fatorial: ");

            if (int.TryParse(Console.ReadLine(), out int numeroFat))
            {
                if (numeroFat >= 0)
                {
                    long resultadoFatorial = CalculaFatorial(numeroFat);
                    Console.WriteLine($"O fatorial de {numeroFat} é: {resultadoFatorial}");
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número não negativo.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }              

        }



        //FUNÇÕES
        static void Cubo(int termoUser3)
        {
            for (int i = 1; i <= termoUser3; i++)
            {
                Console.WriteLine("Termo: " + i + ", Cubo do Termo: " + (i * i * i));
            }
        }


        static void Tabuada1(int tabuada)
        {
            for (int i = 1; i <= tabuada; i++)
            {
                Console.WriteLine($"{tabuada} X {i} = {i * tabuada}");
            }
        }


        //long para lidar com fatoriais de números maiores.
        static long CalculaFatorial(int numFat)
        {
            if (numFat == 0 || numFat == 1)
            {
                return 1;
            }

            long resultado = 1;
            for (int i = 2; i <= numFat; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

    }
}

