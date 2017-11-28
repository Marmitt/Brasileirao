using System;
using System.Collections.Generic;
using System.Linq;

namespace Brasileirao
{
    class TabelaBrasileirao
    {
        public List<Times> times;
        const int quantrebaixados = 4;

        public TabelaBrasileirao() {
            times = new List<Times>();
        }

        public void resultado() {
            for (int i = 0; i < this.times.Count; i++) {
                times.Sort((a, b) => b.pont.CompareTo(a.pont));
                System.Console.WriteLine($"Time: {times[i].time} - Pontuação: {times[i].pont}");

            };
        }
            
    }
}