using System;
using System.Collections.Generic;
using System.Linq;

namespace Brasileirao
{
    class TabelaBrasileirao
    {
        public List<Times> times;

        public TabelaBrasileiro() {
            times = new List<Times>();
        }

        public void resultado() {
            times.ForEach(delegate(Times t) {
                times.Sort(t.pont);
                System.Console.WriteLine($"Time: {t.time} - Pontuação: {t.pont}");
            });
        }
            
    }
}