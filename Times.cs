using System;

namespace Brasileirao
{
    class Times
    {
        private string times;
        private int pontuacao;

        public Times(string nomeTimes, int pont) {
            this.times = nomeTimes;
            this.pontuacao = pont;
        }
        public void dados() {
            System.Console.WriteLine("\ntime: " + times + " | pontuação: " + pontuacao);
        }
    }
} 

