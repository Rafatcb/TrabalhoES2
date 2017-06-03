using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoES.Resources
{
    class Global
    {
        public static short[] mapas = new short[] { 0, 0, 0, 0, 0, 0, 0 }; // 0 - Normal; 1 - Veto
        public static short[] mapaVencedor = new short[5];
        public static short melhorDe, sair = 0;
        public static string time1, time2;
    }
}
