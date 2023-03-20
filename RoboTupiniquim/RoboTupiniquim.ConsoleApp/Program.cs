namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] areaY = new int[5];
            int[] areaX = new int[5];

            int MaxY = 5;
            int MaxX = 5;

            int PosicaoYRobo = 0;
            int PosicaoXRobo = 0;
            char DirecaoRobo = 'N';

            int PosicaoYRobo2 = 0;
            int PosicaoXRobo2 = 0;
            char DirecaoRobo2 = 'N';

            Console.WriteLine("5 5");

            Console.WriteLine(PosicaoYRobo + " " + PosicaoXRobo + " " + DirecaoRobo);

            Console.WriteLine("Digite os comandos do primeiro Robô: ");
            string Comando = Console.ReadLine();

            Console.WriteLine(PosicaoYRobo2 + " " + PosicaoXRobo2 + " " + DirecaoRobo2);

            Console.WriteLine("Digite os comandos do segundo Robô: ");
            string Comando2 = Console.ReadLine();


            char[] ComandoQuebrado = new char[50];
            ComandoQuebrado = Comando.ToUpper().ToCharArray();

            char[] ComandoQuebrado2 = new char[50];
            ComandoQuebrado2 = Comando2.ToUpper().ToCharArray();


            for (int i = 0; i < ComandoQuebrado.Length; i++)
            {
                if (ComandoQuebrado[i] != null)
                {
                        switch (ComandoQuebrado[i])
                        {
                            case 'M':
                                if (DirecaoRobo == 'N')
                                {
                                    if (PosicaoYRobo < MaxY) PosicaoYRobo++;
                                }
                                else if (DirecaoRobo == 'S')
                                {
                                    if (PosicaoYRobo > 0) PosicaoYRobo--;
                                }
                                else if (DirecaoRobo == 'O')
                                {
                                    if (PosicaoXRobo > 0) PosicaoXRobo--;
                                }
                                else if (DirecaoRobo == 'L')
                                {
                                    if (PosicaoXRobo < MaxX) PosicaoXRobo++;
                                }
                                break;
                        
                        case 'E':
                            if (DirecaoRobo == 'N')
                            {
                                DirecaoRobo = 'O';
                            }
                            else if (DirecaoRobo == 'S')
                            {
                                DirecaoRobo = 'O';
                            }
                            else if (DirecaoRobo == 'L')
                            {
                                DirecaoRobo = 'N';
                            }
                            else if (DirecaoRobo == 'O')
                            {
                                DirecaoRobo = 'S';
                            }
                            break;
                        case 'D':
                            if (DirecaoRobo == 'N')
                            {
                                DirecaoRobo = 'L';
                            }
                            else if (DirecaoRobo == 'S')
                            {
                                DirecaoRobo = 'L';
                            }
                            else if (DirecaoRobo == 'L')
                            {
                                DirecaoRobo = 'S';
                            }
                            else if (DirecaoRobo == 'O')
                            {
                                DirecaoRobo = 'N';
                            }
                            break;
                    }
                }
            }

            for (int i = 0; i < ComandoQuebrado2.Length; i++)
            {
                if (ComandoQuebrado2[i] != null)
                {
                    switch (ComandoQuebrado2[i])
                    {
                        case 'M':
                            if (DirecaoRobo2 == 'N')
                            {
                                if (PosicaoYRobo2 < MaxY) PosicaoYRobo2++;
                            }
                            else if (DirecaoRobo2 == 'S')
                            {
                                if (PosicaoYRobo2 > 0) PosicaoYRobo2--;
                            }
                            else if (DirecaoRobo2 == 'O')
                            {
                                if (PosicaoXRobo2 > 0) PosicaoXRobo2--;
                            }
                            else if (DirecaoRobo2 == 'L')
                            {
                                if (PosicaoXRobo2 < MaxX) PosicaoXRobo2++;
                            }
                            break;

                        case 'E':
                            if (DirecaoRobo2 == 'N')
                            {
                                DirecaoRobo2 = 'O';
                            }
                            else if (DirecaoRobo2 == 'S')
                            {
                                DirecaoRobo2 = 'O';
                            }
                            else if (DirecaoRobo2 == 'L')
                            {
                                DirecaoRobo2 = 'N';
                            }
                            else if (DirecaoRobo2 == 'O')
                            {
                                DirecaoRobo2 = 'S';
                            }
                            break;
                        case 'D':
                            if (DirecaoRobo2 == 'N')
                            {
                                DirecaoRobo2 = 'L';
                            }
                            else if (DirecaoRobo2 == 'S')
                            {
                                DirecaoRobo2 = 'L';
                            }
                            else if (DirecaoRobo2 == 'L')
                            {
                                DirecaoRobo2 = 'S';
                            }
                            else if (DirecaoRobo2 == 'O')
                            {
                                DirecaoRobo2 = 'N';
                            }
                            break;
                    }
                }
            }

            Console.WriteLine(PosicaoYRobo + " " + PosicaoXRobo + " " + DirecaoRobo);

            Console.WriteLine(PosicaoYRobo2 + " " + PosicaoXRobo2 + " " + DirecaoRobo2);

            Console.ReadLine();
        }
    }
}