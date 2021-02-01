using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Inputdata;

namespace zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = "a";
        start:
            if (!Input.In1in2(ref var, "viberit variant a/b :"))
                return;

            //var a
            if (var == "a")
            {
                double xp = 3.8, xk = 7.6, sh = 0.4, x, y;
                string output = "";

                if (!Input.Indouble(ref xp, "vvedit x po4atkove:"))
                    return;

                if (!Input.Indouble(ref xk, "vvedit x kinceve:"))
                    return;

                if (!Input.Indouble(ref sh, "vvedit krok:"))
                    return;

                x = xp;

                while (xp <= x  && x <= xk)
                {
                    y = Math.Pow(Math.Sin(x), 2) / Math.Pow(x + 1, 2);

                    output += "\n___________________________________________";
                    output += $"\n|x = {x} | y = {y}|";

                    x += sh;
                }

                if (MessageBox.Show(output + "\n\nPovtor?", "Rezultat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    goto start;
            }


            //var b
            else if (var == "b")
            {
                double xp = 0.5, x, sh = 0.1, n = 9, i, y;
                string output = "";

                i = 0;

                if (!Input.Indouble(ref xp, "vvedit x po4atkove:"))
                    return;

                if (!Input.Indouble(ref sh, "vvedit krok:"))
                    return;

                if (!Input.Indouble(ref n, "vvedit kilkist to4ok:"))
                    return;

                x = xp;

                while (xp <= x && i < n)
                {
                    y = Math.Pow(Math.Sin(x), 2) / Math.Pow(x + 1, 2);

                    output += "\n___________________________________________";
                    output += $"\n|x = {x} | y = {y}|";

                    x += sh;
                    i++;
                }

                if (MessageBox.Show(output + "\n\nPovtor?", "Rezultat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    goto start;
            }

        }
    }
}
