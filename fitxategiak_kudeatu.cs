namespace Proiektua;
public class Fitxategiak_kudeatu
{
    public List<Kontua> Inportatu_kontuak(string fitxategia)
    {
        List<Kontua> kontuak_inportatutak = new List<Kontua>();

        if (!File.Exists(fitxategia))
        {
            Console.WriteLine($"{fitxategia} fitxategia ez da existitzen");
            return kontuak_inportatutak;
        }
        string[] lerroak = File.ReadAllLines(fitxategia);
        int kontadorea = 0;

        foreach (string lerroa in lerroak)
        {
            kontadorea++;
            string[] zatiak = lerroa.Split(","); //hau egingo duena da "," karaktereen artean dauden hitzak banatu, adibidez ni="iraitz,aristi,17,iruñea" bihurtuko da zatia[0]="iraitz", zatia[2]=17...
            if (zatiak.Length >= 4)
            {
                string plataforma = zatiak[0];
                string erabiltzailea = zatiak[1];
                string pasahitza = zatiak[2];
                string mota = zatiak[3];

                Kontua kontuberria;

                kontuberria = new Kontua(plataforma, erabiltzailea, pasahitza, mota);
                kontuak_inportatutak.Add(kontuberria);
            }
            else
            {
                Console.WriteLine("FORMATO OKERRA");
            }
        }
        Console.WriteLine($"{kontuak_inportatutak.Count} kontu inportatu dira");
        return kontuak_inportatutak;
    }

    public static void Esportatu_kontuak(string fitxategia, List<Kontua> kontuak)
    {
        if (kontuak.Count == 0)
        {
            Console.WriteLine("Ez daude kontuak esportatzeko");
        }
        string edukia = "plataforma,erabiltzailea,pasahitza,mota\n";
        foreach (Kontua kont2 in kontuak)
        {
            edukia += kont2.FormatoaFitxategia1()+"\n";
        }
        File.WriteAllText(fitxategia, edukia);
        Console.WriteLine($"{kontuak.Count} kontuak esportatu dira {fitxategia} fitxategira");
    }
}