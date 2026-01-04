using System;
using System.Collections.Generic;

namespace Proiektua
{
    public class Estatistikak
    {
        private Dictionary<string, int> estatMota = new Dictionary<string, int>();
        private Dictionary<string, int> estatPlataforma = new Dictionary<string, int>();

        //Metodo honek balio du estatistikak aktualizatzeko kontu berri bat sortzen den bakoitzean
        public void aktualizatu(Kontua kontuberria)
        {
            string mota = kontuberria.Mota;
            string plataforma = kontuberria.Plataforma;

            //motaren arabera aktualizatu
            if (estatMota.ContainsKey(mota))
            {
                estatMota[mota] = estatMota[mota] + 1;
            }
            else
            {
                estatMota.Add(mota, 1);
            }

            //plataformaren arabera aktualizatu
            if (estatPlataforma.ContainsKey(plataforma))
            {
                estatPlataforma[plataforma] = estatPlataforma[plataforma] + 1;
            }
            else
            {
                estatPlataforma.Add(plataforma, 1);
            }
        }

        public void Erakutsi_estatmota() //estatistikak motaren arabera egiteko balio du
        {
            Console.WriteLine("==== ESTATISTIKAK MOTA ====");
            Console.WriteLine("MOTA            KOPURUA");
            Console.WriteLine("----            -------");

            if (estatMota.Count == 0)
            {
                Console.WriteLine("(Ez dago daturik)");
                return;
            }

            //Hiztegia zeharkatzen dugu
            foreach (KeyValuePair<string, int> parbakoitza in estatMota)
            {
                string mota = parbakoitza.Key;
                if (string.IsNullOrEmpty(mota)) //Hau jartzen da agian hutsik dagoelako eta bestela errorea emango du, zihurtatzen gara emaitza ez dela null
                {
                    mota = "Mota ezezaguna";
                }

                //lerro hau da formato zehatz batekin inpprimatzeko
                Console.WriteLine($"{mota,-15} {parbakoitza.Value}");
            }
        }

        public void Erakutsi_estaplat() //berdina baino plataformena
        {
            Console.WriteLine("===== ESTATISTIKAK PLATAFORMA =====");
            Console.WriteLine("PLATAFORMA      KOPURUA");
            Console.WriteLine("---------       -------");

            if (estatPlataforma.Count == 0)
            {
                Console.WriteLine("Ez dago daturik");
                return;
            }

            foreach (KeyValuePair<string, int> entrada in estatPlataforma)
            {
                string plataforma = entrada.Key;
                if (string.IsNullOrEmpty(plataforma))
                {
                    plataforma = "Plataforma ezezaguna";
                }

                Console.WriteLine($"{plataforma,-15} {entrada.Value}");
            }
        }

        //Metodo honekin etatistikak garbitzen ditugu
        public void Garbitu_dena2()
        {
            estatMota.Clear();
            estatPlataforma.Clear();
            Console.WriteLine("Estatistikak garbitu dira.");
        }

        //metodo honekin lortzen dugu mota baten zenbat kontu daukagu erregistratutak
        public int LortuKopuruaMotagatik(string mota)
        {
            if (estatMota.ContainsKey(mota))
            {
                return estatMota[mota];
            }
            return 0;
        }

        //metodo honekin lortzen dugu plataforma baten zenbat kontu daukagu erregistratutak
        public int LortuKopuruaPlataformagatik(string plataforma)
        {
            if (estatPlataforma.ContainsKey(plataforma))
            {
                return estatPlataforma[plataforma];
            }
            return 0;
        }
    }
}