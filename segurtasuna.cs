namespace Proiektua;
public class Segurtasuna
{
    public static void Segurtasuna_pasahitzak(List<Kontua> kontuak)
    {
        int pasahitza_inseguruak = 0;
        Console.WriteLine("==== PASAHITZEN SEGURTASUNA ====");
        Console.WriteLine("Kontuak pasahitz laburrekin (<8 karaktere) ikusi");

        foreach (Kontua kont4 in kontuak)
        {
            if (kont4.Pasahitza.Length < 8)
            {
                Console.WriteLine($"KONTU INSEGURUA: {kont4.Plataforma} - {kont4.Erabiltzailea}: {kont4.Pasahitza.Length} karaktere");
                pasahitza_inseguruak++;
            }
        }
        if (pasahitza_inseguruak == 0)
        {
            Console.WriteLine("Pasahitz guztiak seguruak dira (8 karaktere baino gehiago dituzte)");
        }
        else
        {
            Console.WriteLine($"{pasahitza_inseguruak} kontu daude pasahitz inseguruekin (8 karaktere edo gutxiago)");
        }
    }
}