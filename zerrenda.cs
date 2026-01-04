using System.IO.Compression;

namespace Proiektua;

public class Zerrenda
{
    private List<Kontua> kontuak = new List<Kontua>();

    public void Kontua_gehitu(Kontua kontuberria)
    {
        if (kontuak.Count >= 100)
        {
            Console.WriteLine("Gehienez 100 kontu sortu ahal dituzu momentuz.");
            return;
        }

        kontuak.Add(kontuberria);
        Console.WriteLine($"Kontua ongi gehitu da: {kontuberria.Plataforma} - {kontuberria.Erabiltzailea}");
    }

    public bool Kontua_ezabatu(int index)
    {
        if (index >= 0 && index < kontuak.Count)
        {
            Kontua ezabatutakoa = kontuak[index];
            kontuak.RemoveAt(index);
            Console.WriteLine($"Kontua ezabatu da: {ezabatutakoa.Plataforma}");
            return true;
        }
        return false;
    }

    public void Erakutsi_kontuak()
    {
        if (kontuak.Count == 0)
        {
            Console.WriteLine("Oraindik ez daude konturik");
            return;
        }

        Console.WriteLine($"==== KONTU GUZTIAK ({kontuak}) ====");
        for (int i = 0; i < kontuak.Count; i++)
        {
            Console.WriteLine($"[KONTUA #{i+1}]");
            kontuak[i].Erakutsi();
        }
    }

    public List<Kontua> Bil_plat(string plataforma)
    {
        List<Kontua> bil_emaitzak = new List<Kontua>();

        foreach (Kontua kont in kontuak)
        {
            if (kont.Plataforma.ToLower().Contains(plataforma.ToLower()))
            {
                bil_emaitzak.Add(kont);
            }
        }
        return bil_emaitzak;
    }

    public Kontua Lortu_kontua(int index)
    {
        if (index >= 0 && index < kontuak.Count)
        {
            return kontuak[index];
        }
            return null;
    }

    public int Kontu_kopurua()
    {
        return kontuak.Count;
    }

    public void Garbitu_dena()
    {
        kontuak.Clear();
        Console.WriteLine("Kontuen zerrenda garbitu da.");
    }

    public List<Kontua> Lortu_kontuguztiak() //hau ere sortzen dut horrela erabiltzaileak kontuak esportatu ahalko du, ere hou erabili ahal dugu kontu guztiak erakutseko program.cs fitxategian
    {
        return kontuak;
    }

    //Getter kontatzeko
    public int KontuKopurua 
    { 
        get { return kontuak.Count; }
    }
    
    public void Ezabatu_zerrenda()
    {
        if (kontuak.Count > 0)
        {
            Console.WriteLine($"{kontuak.Count} kontu ezabatuko dira...");
            kontuak = new List<Kontua>();  //Hau lista berri bat da konturik gabe, orduan ya zeuden kontu guztiak ezabatzen dira.
            Console.WriteLine("Zerrenda berrezarrita.");
        }
    }
}