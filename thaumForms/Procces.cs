using System;
using System.Collections.Generic;

namespace thaumForms
{
    public class Procces
    {
        List<string> select_asp = new List<string>();
        List<int> num = new List<int>();
        public void Input(string text, int z)
        {
            if (text == "clear")
            {
                select_asp.Clear();
                num.Clear();
                return;
            }
            num.Add(z);
            select_asp.Add(text);
        }
        public List<string> Calculation(string quality)
        {
            //creating list
            List<Asp> list = new List<Asp>();
            // don`t open pls
            {
                // name, aer, ignis, perditio, terra, aqua, ordo
                list.Add(new Asp("aer", 1, 0, 0, 0, 0, 0));
                list.Add(new Asp("ignis", 0, 1, 0, 0, 0, 0));
                list.Add(new Asp("perditio", 0, 0, 1, 0, 0, 0));
                list.Add(new Asp("terra", 0, 0, 0, 1, 0, 0));
                list.Add(new Asp("aqua", 0, 0, 0, 0, 1, 0));
                list.Add(new Asp("ordo", 0, 0, 0, 0, 0, 1));
                list.Add(new Asp("lux", 1, 1, 0, 0, 0, 0));
                list.Add(new Asp("vacuos", 1, 0, 1, 0, 0, 0));
                list.Add(new Asp("permutatio", 0, 0, 1, 0, 0, 1));
                list.Add(new Asp("tempestas", 1, 0, 0, 0, 1, 0));
                list.Add(new Asp("motus", 1, 0, 0, 0, 0, 1));
                list.Add(new Asp("venenum", 0, 0, 1, 0, 1, 0));
                list.Add(new Asp("victus", 0, 0, 0, 1, 1, 0));
                list.Add(new Asp("vitreus", 0, 0, 0, 1, 0, 1));
                list.Add(new Asp("potentia", 0, 1, 0, 0, 0, 1));
                list.Add(new Asp("gelum", 0, 0, 1, 0, 0, 1));
                list.Add(new Asp("tenebrae", 1, 1, 1, 0, 0, 0));
                list.Add(new Asp("volatus", 1, 0, 0, 0, 0, 1));
                list.Add(new Asp("vinculum", 1, 0, 1, 0, 0, 1));
                list.Add(new Asp("bestia", 1, 0, 0, 1, 1, 1));
                list.Add(new Asp("iter", 1, 0, 0, 1, 0, 1));
                list.Add(new Asp("mortuus", 0, 0, 1, 1, 1, 0));
                list.Add(new Asp("limus", 0, 0, 0, 1, 1, 0));
                list.Add(new Asp("sano", 0, 0, 0, 1, 1, 1));
                list.Add(new Asp("herba", 0, 0, 0, 1, 1, 0));
                list.Add(new Asp("metallum", 0, 0, 0, 0, 1, 1));
                list.Add(new Asp("precantatio", 1, 1, 1, 0, 0, 1));
                list.Add(new Asp("fames", 1, 0, 1, 1, 1, 0));
                list.Add(new Asp("alienis", 1, 1, 1, 0, 0, 0));
                list.Add(new Asp("corpus", 1, 0, 1, 1, 1, 1));
                list.Add(new Asp("exanimus", 1, 0, 1, 1, 1, 1));
                list.Add(new Asp("spiritus", 0, 0, 1, 1, 1, 0));
                list.Add(new Asp("arbor", 1, 0, 0, 1, 1, 0));
                list.Add(new Asp("auram", 1, 1, 1, 0, 0, 1));
                list.Add(new Asp("vitium", 1, 1, 1, 0, 0, 1));
                list.Add(new Asp("sensus", 1, 0, 1, 1, 1, 0));
                list.Add(new Asp("cognitio", 0, 1, 1, 1, 1, 0));
                list.Add(new Asp("humanus", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("lucrum", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("instrumentum", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("perfodio", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("messis", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("fabrico", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("machina", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("pannus", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("telum", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("tutamen", 1, 1, 1, 1, 1, 1));
                list.Add(new Asp("meto", 1, 1, 1, 1, 1, 1));                      //fuck i write this shit 20 minutes :)
            }
            List<Asp> Current = new List<Asp>();

            List<int> x = new List<int>();
            //finding machine
            for (int i = 0; i < select_asp.Count; i++)
            {
                for (int n = 0; n < list.Count; n++)
                {
                    if (list[n].name == select_asp[i])
                    {
                        Current.Add(list[n]);
                        x.Add(num[i]);
                    }
                }
            }
            //node quality
            double qualityCoef;
            switch (quality)
            {
                case "Bright": qualityCoef = 1.2; break;
                case "Normal": qualityCoef = 1; break;
                case "Pale": qualityCoef = .8; break;
                case "Fading": qualityCoef = .6; break;
                default: qualityCoef = 1; break;
            }

            Asp Result = new Asp("", 0, 0, 0, 0, 0, 0);

            for (int i = 0; i < Current.Count; i++)
            {
                if (Current[i].aer * x[i] > Result.aer) Result.aer = Current[i].aer * x[i];
                if (Current[i].ignis * x[i] > Result.ignis) Result.ignis = Current[i].ignis * x[i];
                if (Current[i].perditio * x[i] > Result.perditio) Result.perditio = Current[i].perditio * x[i];
                if (Current[i].terra * x[i] > Result.terra) Result.terra = Current[i].terra * x[i];
                if (Current[i].aqua * x[i] > Result.aqua) Result.aqua = Current[i].aqua * x[i];
                if (Current[i].ordo * x[i] > Result.ordo) Result.ordo = Current[i].ordo * x[i];
            }

            //some math (amount of basic aspects in aspect * amount on node * quality )
            double[] aspects = new double[6];

            aspects[0] = Math.Round(Result.aer * qualityCoef);
            aspects[1] = Math.Round(Result.ignis * qualityCoef);
            aspects[2] = Math.Round(Result.perditio * qualityCoef);
            aspects[3] = Math.Round(Result.terra * qualityCoef);
            aspects[4] = Math.Round(Result.aqua * qualityCoef);
            aspects[5] = Math.Round(Result.ordo * qualityCoef);

            //more some math 
            for (int i = 0; i < aspects.Length; i++)
            {
                if (1 <= aspects[i] && aspects[i] <= 3) aspects[i] = 1;
                else if (4 <= aspects[i] && aspects[i] <= 8) aspects[i] = 2;
                else if (9 <= aspects[i] && aspects[i] <= 16) aspects[i] = 3;
                else if (17 <= aspects[i] && aspects[i] <= 25) aspects[i] = 4;
                else if (26 <= aspects[i] && aspects[i] <= 36) aspects[i] = 5;
                else if (37 <= aspects[i] && aspects[i] <= 50) aspects[i] = 6;
                else if (51 <= aspects[i] && aspects[i] <= 65) aspects[i] = 7;
                else if (66 <= aspects[i] && aspects[i] <= 82) aspects[i] = 8;
                else if (83 <= aspects[i] && aspects[i] <= 99) aspects[i] = 9;
                else if (100 <= aspects[i]) aspects[i] = 10;
            }

            List<string> output = new List<string>();
            for (int i = 0; i < aspects.Length; i++)
            {
                output.Add(Convert.ToString(Convert.ToInt32(aspects[i])));
            }

            return output;
        }

    }
}
