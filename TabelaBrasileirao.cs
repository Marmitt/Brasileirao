using System;

namespace Brasileirao
{
    class TabelaBrasileirao
    {
        public ListaTimes times = new ListaTimes();
        public void tabela() {
            System.Console.WriteLine("Tabela Brasileirão");
            System.Console.WriteLine("1 - Adiciona os times e a pontuação/n2 - Exibe o resultado da tabela");
        }
    }
}