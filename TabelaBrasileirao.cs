using System;
using System.Collections.Generic;
using System.Linq;

namespace Brasileirao
{
    class TabelaBrasileirao
    {
        public List<Times> times;

        public TabelaBrasileirao() {
            times = new List<Times>();
        }

        public void resultado() {
            times.ForEach(delegate(Times t) {
                System.Console.WriteLine($"Time: {t.time} - Pontuação: {t.pont}");

            });
        }
            
    }
}