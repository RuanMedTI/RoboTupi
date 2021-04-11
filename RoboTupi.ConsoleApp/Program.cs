using System;

namespace RoboTupi.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] posicoesInseridas = new string[100];
            string opcao = "";
            int contadorPosicaoInserida = 0;

            while (true)
            {
                MostrarMenu();

                opcao = Console.ReadLine();

                if (EhOpcaoInvalida(opcao))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Opcao Invalida! Apenas 1, 2 e S");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (opcao == "2")
                {
                    Console.WriteLine();

                    if (contadorPosicaoInserida == 0)
                    {
                        Console.WriteLine("Nenhuma posição foi inserida");
                    }
                    else
                    {

                        for (int i = 0; i < posicoesInseridas.Length; i++)
                        {
                            if (posicoesInseridas[i] != null)
                                Console.WriteLine(posicoesInseridas[i]);
                        }
                    }

                    Console.ReadLine();

                    Console.Clear();
                    continue;
                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                double primeiroX, primeiroY, segundoX, segundoY;

                string orient, orientf;

                Console.Write("Digite a posição inicial X do robô: ");
                primeiroX = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a posição inicial Y do robô: ");
                primeiroY = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a orientação inicial do robô: ");
                orient = Convert.ToString(Console.ReadLine());

                Console.Write("Digite a posição final X do robô: ");
                segundoX = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a posição final Y do robô: ");
                segundoY = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a orientação final do robô: ");
                orientf = Convert.ToString(Console.ReadLine());

                string simboloMoviment = "";

                switch (opcao)
                {
                    case "1":
                        if (primeiroY < segundoY)
                        {
                            simboloMoviment = "E";
                        }
                        if (primeiroX < segundoX)
                        {
                            simboloMoviment = "M";
                        }                      

                        break;
     
                    default:
                        break;
                }

                string posicaoInserida =
                 simboloMoviment +
                 simboloMoviment +
                 simboloMoviment;




                posicoesInseridas[contadorPosicaoInserida] = posicaoInserida;
                contadorPosicaoInserida++;                

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();

            }
        }

        private static bool EhOpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "S" && opcao != "s";
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("Robô Tupiniquim I");

            Console.WriteLine("Digite 1 para inserir posição ao robô");

            Console.WriteLine("Digite 2 para visualizar a movimentação do robô");

            Console.WriteLine("Digite S para sair");
        }
    }
}
