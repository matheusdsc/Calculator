using System;

namespace Calculator
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Divisão");
            Console.WriteLine("4. Multiplicação");
            Console.WriteLine("5. Raiz quadrada");
            Console.WriteLine("6. Potência");
            Console.WriteLine("7. Porcentagem");
            Console.WriteLine("8. Sair");


            Console.WriteLine("--------------------");
            Console.Write("Selecione uma opção: ");

            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: raiz(); break;
                case 6: potencia(); break;
                case 7: porcentagem(); break;
                case 8: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Primeiro Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"O reslultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O reslultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void raiz()
        {
            Console.Clear();
            Console.Write("Insira o valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Convert.ToSingle(Math.Sqrt(v1));
            Console.WriteLine($"O reslultado da raiz quadrada é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void potencia()
        {
            Console.Clear();
            Console.Write("Insira a base: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Insira o expoente: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Convert.ToSingle(Math.Pow(v1, v2));
            Console.WriteLine($"O reslultado da potência é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void porcentagem()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Valor da porcentagem: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * (v2 / 100);
            Console.WriteLine($"O reslultado da porcentagem é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}