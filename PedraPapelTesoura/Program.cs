using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo Parte A iniciado!!");
            var ganhadorPartA = JogoPartA();
            Console.WriteLine(string.Format("Jogador {0} ganhou!!!", ganhadorPartA));

            Console.WriteLine("Jogo Parte B iniciado!!");
            var ganhadorPartB = JogoPartB();
            Console.WriteLine(string.Format("Jogador {0} ganhou!!!", ganhadorPartB));

            Console.ReadKey();
        }

        private static string JogoPartA()
        {
            int qtdJogadores = 0;
            Console.WriteLine("Digite a quantidade de participantes: ");
            Int32.TryParse(Console.ReadLine(), out qtdJogadores);

            if (qtdJogadores != 2)
            {
                Console.WriteLine("Número diferente de 2");
                return JogoPartA();
            }

            string[][] a = new string[qtdJogadores][];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite o nome do participante " + (i + 1));
                string nome = Console.ReadLine();
                string jogada = ObterJogadaDoParticipante(nome);
                a[i] = new string[] { nome, jogada };
            }

            while (a.Length > 1)
            {
                a = Jogar(a);
            }

            return a[0][0];
        }

        private static string JogoPartB()
        {
            var j1 = new string[] { "Armando", "P" };
            var j2 = new string[] { "Dave", "s" };
            var j3 = new string[] { "Richard", "R" };
            var j4 = new string[] { "Michael", "S" };
            var j5 = new string[] { "Allen", "S" };
            var j6 = new string[] { "Omer", "P" };
            var j7 = new string[] { "David", "R" };
            var j8 = new string[] { "Richard w", "P" };

            var a = new string[8][] { j1, j2, j3, j4, j5, j6, j7, j8 };

            while (a.Length > 1)
            {
                a = Jogar(a);
            }

            return a[0][0];
        }

        private static string[][] Jogar(string[][] a)
        {
            var temp = new string[a.Length / 2][];
            var j = 0;
            for (int i = 0; i < a.Length; i = i + 2)
            {
                temp[j] = Vencedor(a[i], a[i + 1]);
                j++;
            }
            return temp;
        }

        private static string[] Vencedor(string[] jogador1, string[] jogador2)
        {
            string jogada = jogador1[1] + jogador2[1];

            string[] ganha = { "RS", "SP", "PR", "R", "S", "P", "RR", "SS", "PP" };

            if (ganha.Contains(jogada))
            {
                return jogador1;
            }
            else
            {
                return jogador2;
            }
        }

        private static string ObterJogadaDoParticipante(string nome)
        {
            Console.WriteLine("Digite a jogada do participante " + nome);
            var jogada = Console.ReadLine().ToUpper();
            if (jogada != "S" && jogada != "P" && jogada != "R")
            {
                Console.WriteLine("Jogada inválida(digite p,s ou r)");
                ObterJogadaDoParticipante(nome);
            }

            return jogada;
        }
    }
}
