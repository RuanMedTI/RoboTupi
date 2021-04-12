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

                //vai chamar o metodo e caso não exista na opcao mostrar a mensagem de opcao invalida
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

                    //caso nao tenha nenhuma posicao inserida no robo, vai apresentar a mensagem
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
                //aqui esta recebendo os valores do usuario
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
                        //se o primeiro valor informado no Y for menor que o segundo Y
                        //o robo irá se mover seguindo o if
                        if (primeiroY < segundoY)
                        {
                            simboloMoviment = "E";
                        }
                        //aqui da mesma maneira, mas com o valor do eixo x do robo
                        if (primeiroX < segundoX)
                        {
                            simboloMoviment = "M";
                        }                      

                        break;
     
                    default:
                        break;
                }

                string posicaoInserida =
                 segundoX.ToString() +
                 segundoY.ToString() +
                 orientf.ToString() +

                 "---------------------------------" +

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
        //opcoes 1 2 e S 
        private static bool EhOpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "S" && opcao != "s";
        }
        //opcoes do menu do robo tupiniquim 
        private static void MostrarMenu()
        {
            Console.WriteLine("Robô Tupiniquim I");

            Console.WriteLine("Digite 1 para inserir posição ao robô");

            Console.WriteLine("Digite 2 para visualizar a movimentação do robô");

            Console.WriteLine("Digite S para sair");
        }
    }
}
