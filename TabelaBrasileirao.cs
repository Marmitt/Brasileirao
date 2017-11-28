using System;
using System.Collections.Generic;
using System.Linq;

namespace Brasileirao
{
    class TabelaBrasileirao
    {
        public List<Times> times;
        const int quantreb = 1;

        public TabelaBrasileirao() {
            times = new List<Times>();
        }

        public void resultado() {
            string premiacao = "";
            for (int i = 0; i < this.times.Count; i++) {
                if (i == 0)
                    premiacao = "= Campeão";
                if (i >= 2)
                if (i >= this.times.Count - quantreb)
                    premiacao = "= Rebaixado";
                times.Sort((a, b) => b.pont.CompareTo(a.pont));
                System.Console.WriteLine($"Time: {times[i].time} - Pontuação: {times[i].pont} {premiacao}");
            };      
        }            
    }
}