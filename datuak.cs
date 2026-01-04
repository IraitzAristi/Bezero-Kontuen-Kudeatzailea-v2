using System;

namespace Proiektua
{
    public static class Datuak
    {
        //hurrengo kode zatia da array bat kontu motekin, gero program.cs fitxategitik kontu mota hauek deitzen ditut.
        public static string[] KontuMotak = 
        {
            "SOziala", "Lana", "Pertsonala", "Bankukoa",
            "Eskolakoa", "Erosketak", "Entretenimendua"
        };

        public static void ErakutsiMotak()
        {
            Console.WriteLine("\n--- TIPOS DISPONIBLES ---");
            for (int i = 0; i < KontuMotak.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {KontuMotak[i]}");
            }
        }
    }
}