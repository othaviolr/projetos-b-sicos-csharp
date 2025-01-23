using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            if (!int.TryParse(Console.ReadLine(), out int numero1))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                return;
            }

            Console.Write("Digite o segundo valor: ");
            if (!int.TryParse(Console.ReadLine(), out int numero2))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                return;
            }

            Console.WriteLine("Selecione a operação: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            if (!int.TryParse(Console.ReadLine(), out int operacao) || operacao < 1 || operacao > 4)
            {
                Console.WriteLine("Por favor, selecione uma operação válida (1 a 4).");
                return;
            }
            
            string resultado = Calcular(numero1, numero2, operacao);
            Console.WriteLine(resultado);
        }
        
        static string Calcular(int numero1, int numero2, int operacao)
        {
            switch (operacao)
            {
                case 1:
                    return $"Resultado da soma: {numero1 + numero2}";
                case 2:
                    return $"Resultado da subtração: {numero1 - numero2}";
                case 3:
                    return $"Resultado da multiplicação: {numero1 * numero2}";
                case 4:
                    if (numero2 == 0)
                        return "Erro: Divisão por zero não é permitida.";
                    return $"Resultado da divisão: {(double)numero1 / numero2}";
                default:
                    return "Operação inválida.";
            }
        }
    }
}
