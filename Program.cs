using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_do_Dado
{
	internal class Program
	{
		static void Main(string[] args)
		{
			JogoDado();
		}


		static void JogoDado()
		{
			int NumeroAleatorioJogaor;
			int NumeroAleatorioCPU;

			int PontosJogador = 0;
			int PontosCPU = 0;

			Random random = new Random();

			for (int contador = 0; contador < 10; contador++)
			{
				Console.Write("Digite qualquer tecla para rodar o dado: ");
				Console.ReadKey();/*Captuar qualquer tecla do teclado*/
				Console.WriteLine("");



				/*Gerar um numero aleatorio entre 1 e 6*/
				NumeroAleatorioJogaor = random.Next(1, 7);
				Console.WriteLine($"Voce rolou o dado {NumeroAleatorioJogaor} vezes");

				Console.WriteLine("......");
				Thread.Sleep(3000);

				NumeroAleatorioCPU = random.Next(1, 7);
				Console.WriteLine($"A CPU rolou o dado {NumeroAleatorioCPU} vezes ");

				Console.WriteLine("......");
				Thread.Sleep(3000);

				/*Se o jogador rolou o dado mais vezes que a CPU*/
				if (NumeroAleatorioJogaor > NumeroAleatorioCPU)
				{
					PontosJogador++;
					Console.WriteLine("O jogador venceu esse round");
					Console.WriteLine("--------------------------------------");

				}
				else if (NumeroAleatorioJogaor < NumeroAleatorioCPU)
				{
					PontosCPU++;
					Console.WriteLine("A CPU venceu esse round");
					Console.WriteLine("--------------------------------------");

				}
				else
				{
					Console.WriteLine("EMPATOU NESSA RODADA!");
					Console.WriteLine("--------------------------------------");

				}
			}

			if (PontosJogador > PontosCPU) { Console.WriteLine("O jogador VENCEU!"); }
			else if (PontosJogador < PontosCPU) { Console.WriteLine("A CPU VENCEU!"); }
			else { Console.WriteLine("EMPATOU"); }

		}

	}
}
