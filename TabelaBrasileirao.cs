using System;
using System.Collections.Generic;

namespace Brasileirao
{
    class TabelaBrasileirao
    {
        public ListaTimes times = new ListaTimes();
        public void tabela() {
            System.Console.WriteLine("Tabela Brasileirão");
            System.Console.WriteLine("Enter - Adiciona os times e a pontuação/n0 - Exibe o resultado da tabela");

            while (Console.ReadKey().Key == ConsoleKey.Enter) {
                System.Console.WriteLine("Nome Do Time: ");
                string time = Console.ReadLine();
            }
        }
    }
}