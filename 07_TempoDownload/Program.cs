using System;

namespace _07_TempoDownload
{
    using System;

    namespace _07_TempoDownload
    {
        class Program
        {
            static void Main(string[] args)
            {
                double tamanhoMB = 0;
                double velocidadeMbps = 0;

                // Entrada e validação do tamanho do arquivo
                while (tamanhoMB <= 0)
                {
                    Console.Write("Digite o tamanho do arquivo (em MB): ");
                    if (!double.TryParse(Console.ReadLine(), out tamanhoMB) || tamanhoMB <= 0)
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                    }
                }

                // Entrada e validação da velocidade da internet
                while (velocidadeMbps <= 0)
                {
                    Console.Write("Digite a velocidade da internet (em Mbps): ");
                    if (!double.TryParse(Console.ReadLine(), out velocidadeMbps) || velocidadeMbps <= 0)
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                    }
                }

                // Cálculo do tempo de download
                double tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
                double tempoMinutos = tempoSegundos / 60;

                // Exibição do resultado
                Console.WriteLine($"\nTempo aproximado de download: {tempoMinutos:F2} minutos");

                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}
