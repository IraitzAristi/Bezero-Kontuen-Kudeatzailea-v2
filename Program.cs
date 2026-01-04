using System.Formats.Asn1;
using System.IO.Compression;
using System.Reflection;
using System;
using System.Collections.Generic;

namespace Proiektua;
public class Program
{
        static Zerrenda kontuZerrenda = new Zerrenda();
        static Estatistikak estatistikak = new Estatistikak();
        static Fitxategiak_kudeatu fitxategiak = new Fitxategiak_kudeatu();
    static bool piztuta = true;
    static void Main(string[] args)
    {
        Console.WriteLine("\n====ALLSECURITY ENPRESARAKO BEZERO KONTUEN KUDEATZAILEA====\n");
        Console.WriteLine("Zure datu guztiak modu seguruan gordetzen ditugu\n");
        while (piztuta)
        {
            Menua();
        }
        Console.WriteLine($"Kontu kopurua: {kontuZerrenda.Kontu_kopurua()}");
        Console.WriteLine("Zure datuak seguru daude, Agur");
    }

    public static void Menua()
    {
        Console.WriteLine("--MENUA--");
        Console.WriteLine("1. Kontu berria sortu");
        Console.WriteLine("2. Plataformagatik kontuak bilatu");
        Console.WriteLine("3. Estatistikak ikusi");
        Console.WriteLine("4. Kontuak inportatu (fitxategi batetik)");
        Console.WriteLine("5. Kontuak esportatu (fitxategi batera)");
        Console.WriteLine("6. Pasahitzen segurtasuna");
        Console.WriteLine("7. Kontu kopurua ikusi");
        Console.WriteLine("8. Kontu guztiak ezabatu");
        Console.WriteLine("9. Zerrendatu kontu guztiak");
        Console.WriteLine("0. Atera\n");
        Console.Write("Aukeratu bat (0-9): ");
        string aukera = Console.ReadLine()!;

        switch (aukera)
        {
            case "1":
                Kontua_berria();
                break;

            case "2":
                Bilatu_kontuak();
                break;

            case "3":
                Erakutsi_estatistikak();
                break;

            case "4":
                Inportatu_kontuak();
                break;

            case "5":
                Esportatu_kontuak();
                break;

            case "6":
                Segurtasuna_pasahitzak();
                break;

            case "7":
                Kontuak_kopurua();
                break;

            case "8":
                Datuak_garbitu();
                break;
            
            case "9":
                kontu_guztiak();
                break;

            case "0":
                Console.WriteLine("Programatik ateratzen...");
                piztuta = false;
                break;

            default:
                Console.WriteLine("Jarri duzun karakterea ez da egokia.");
                break;
        }
    }

    public static void kontu_guztiak()
    {
        Console.WriteLine("\n==== KONTU GUZTIAK ====");
        
        if (kontuZerrenda.Kontu_kopurua() == 0)
        {
            Console.WriteLine("Ez dago konturik erregistratuta.");
            Console.WriteLine("Pulsatu Enter jarraitzeko...");
            Console.ReadLine();
            return;
        }
        
        Console.WriteLine($"\nGuztira: {kontuZerrenda.Kontu_kopurua()} kontu daude");
        
        //listan kontu guztiak aukeratzen ditugu lerro honekin (lista horretan kontu guztiak daude)
        List<Kontua> kontuak = kontuZerrenda.Lortu_kontuguztiak();
        
        for (int i = 0; i < kontuak.Count; i++)
        {
            Console.WriteLine($"\n[KONTUA #{i + 1}]");
            kontuak[i].Erakutsi();
        }
        
        Console.WriteLine("Pulsatu Enter jarraitzeko...");
        Console.ReadLine();
    }

    public static void Kontua_berria()
    {
        Console.WriteLine("  KONTU BERRIA SORTU");
        
        Console.Write("  Plataforma: ");
        string plataforma = Console.ReadLine()!;
        
        Console.Write("  Erabiltzailea: ");
        string erabiltzailea = Console.ReadLine()!;
        
        Console.Write("  Pasahitza: ");
        string pasahitza = Console.ReadLine()!;
        
        // Mostrar tipos
        Console.WriteLine("\n  --- MOTAK ---");
        string[] motak = Datuak.KontuMotak;
        
        for (int i = 0; i < motak.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {motak[i]}");
        }
        
        Console.Write("\nMota (idatzi zenbakia): ");
        string motaAukera = Console.ReadLine()!;
        
        bool aurkitua = false;
        string mota = "";
        
        switch (motaAukera)
        {
            case "1":
                mota = motak[0];
                aurkitua = true;
                break;

            case "2":
                mota = motak[1];
                aurkitua = true;
                break;

            case "3":
                mota = motak[2];
                aurkitua = true;
                break;

            case "4":
                mota = motak[3];
                aurkitua = true;
                break;

            case "5":
                mota = motak[4];
                aurkitua = true;
                break;

            case "6":
                mota = motak[5];
                aurkitua = true;
                break;

            case "7":
                mota = motak[6];
                aurkitua = true;
                break;

            default: 
                Console.WriteLine("Mota ez egokia."); 
                return;
        }
        
        if (aurkitua)
        {
            Kontua kontuberria = new Kontua(plataforma, erabiltzailea, pasahitza, mota);
            kontuZerrenda.Kontua_gehitu(kontuberria);
            estatistikak.aktualizatu(kontuberria);
            
            Console.WriteLine($"\nKontua ongi sortu da");
            Console.WriteLine($"Plataforma: {plataforma}");
            Console.WriteLine($"Erabiltzailea: {erabiltzailea}");
            Console.WriteLine($"Mota: {mota}");
        }
    }
    
    public static void Bilatu_kontuak()
    {

        Console.Write("\nPlataforma: ");
        string plataformaBilatu = Console.ReadLine()!;
        
        //lerro hau kontuak bilatzeko listan balio du
        List<Kontua> aurkitutakoak = kontuZerrenda.Bil_plat(plataformaBilatu);
        
        if (aurkitutakoak.Count == 0)
        {
            Console.WriteLine($"Ez da konturik aurkitu '{plataformaBilatu}' plataformarekin.");
        }
        else
        {
            Console.WriteLine($"\n{aurkitutakoak.Count} kontu aurkitu dira:");
            
            for (int i = 0; i < aurkitutakoak.Count; i++)
            {
                {
                    Console.WriteLine($"\n[KONTUA #{i + 1}]");
                    aurkitutakoak[i].Erakutsi();
                    Console.WriteLine($"\n[KONTUA #{i + 1}] - ERROR erakusten");
                    Console.WriteLine($"  Plataforma: {aurkitutakoak[i].Plataforma}");
                    Console.WriteLine($"  Erabiltzailea: {aurkitutakoak[i].Erabiltzailea}");
                }
            }        
        }
    
    Console.WriteLine("\nSakatu Enter jarraitzeko...");
    Console.ReadLine();

    }

    static void Erakutsi_estatistikak()
    {
        Console.WriteLine("\n1. Estatistikak motaren arabera");
        Console.WriteLine("2. Estatistikak plataformaren arabera");
        Console.WriteLine("3. Atzera");
        Console.Write("Aukeratu: ");
        
        string aukera = Console.ReadLine()!;
        
        switch (aukera)
        {
            case "1":
                estatistikak.Erakutsi_estatmota();
                break;
                
            case "2":
                estatistikak.Erakutsi_estaplat();
                break;
                
            case "3":
                Console.WriteLine("Atzera joaten...");
                break;
                
            default:
                Console.WriteLine("Aukera okerra.");
                break;
        }
    
        //Pausa hauek gehitzen ditut horrela denbora dago erabiltzaileak emaitzak ikusteko eta bestela ez da geratzen txukuna
        Console.WriteLine("\npulsatu Enter jarraitzeko...");
        Console.ReadLine();
    }
        
        static void Inportatu_kontuak()
        {
            Console.Write("Fitxategiaren izena: ");
            string izena = Console.ReadLine()!;
            
            List<Kontua> inportatutakoak = fitxategiak.Inportatu_kontuak(izena);
            
            foreach (Kontua kont3 in inportatutakoak)
            {
                kontuZerrenda.Kontua_gehitu(kont3);
                estatistikak.aktualizatu(kont3);
            }
        }
        static void Esportatu_kontuak()
        {
            Console.Write("Fitxategiaren izena (adibidez: kontuak.txt): ");
            string izena = Console.ReadLine()!;
            
            Fitxategiak_kudeatu.Esportatu_kontuak(izena, kontuZerrenda.Lortu_kontuguztiak());
        }
        static void Segurtasuna_pasahitzak()
        {
            Segurtasuna.Segurtasuna_pasahitzak(kontuZerrenda.Lortu_kontuguztiak());
        }
        public static void Datuak_garbitu()
        {
            Console.WriteLine("\n==== KONTUAK EZABATU ====");
            Console.WriteLine($"Orain {kontuZerrenda.Kontu_kopurua()} kontu dituzu.");
            
            Console.Write("Ziur zaude? (BAI/EZ): ");
            string erantzuna = Console.ReadLine()!.ToUpper();
            
            if (erantzuna == "BAI")
            {
                kontuZerrenda.Ezabatu_zerrenda();
                estatistikak.Garbitu_dena2();
            }
            else
            {
                Console.WriteLine("Ez da ezer ezabatu.");
            }
        }
    
        public static void Kontuak_kopurua()
        {
            Console.WriteLine($"Orain {kontuZerrenda.Kontu_kopurua()} kontu daude erregistratutak");
            return;
        }
}