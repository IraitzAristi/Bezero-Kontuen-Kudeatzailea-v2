using System;

namespace Proiektua;

public class Kontua
{
    private string plataforma;
    private string erabiltzailea;
    private string pasahitza;
    private string mota;

        //Lerro hau da nire eraikitzailea
    public Kontua(string plataforma, string erabiltzailea, string pasahitza, string mota)
    {
        //?? eta "" erabiltzem da esateko adibidez plataforma null bada (ez dauka baliorik) erabiltzeko string hutsa ("")
        this.plataforma = plataforma ?? "";
        this.erabiltzailea = erabiltzailea ?? "";
        this.pasahitza = pasahitza ?? "";
        this.mota = mota ?? "Pertsonala";
    }

        //Getter eta setter-ak
    public string Plataforma 
    { 
        get {return plataforma;}
        set {plataforma = value ?? "";}
    }

    public string Erabiltzailea 
    { 
        get {return erabiltzailea;}
        set {erabiltzailea = value ?? "";}
    }

    public string Pasahitza 
    { 
        get {return pasahitza;}
        set {pasahitza = value ?? "";}
    }

    public string Mota 
    { 
        get {return mota;}
        set {mota = value ?? "Pertsonala";}
    }


    public void Erakutsi()
    {
        Console.WriteLine($"PLATAFORMA: {plataforma}");
        Console.WriteLine($"ERABILTZAILEA: {erabiltzailea}");
            
            //beste prgraman bezala zati hau zihurtatzen du emaitza ez dela null hurrengo zatira pasatu baino lehen
        if (string.IsNullOrEmpty(pasahitza))
        {
            Console.WriteLine("PASAHITZA: (ez dago)");
        }
        else
        {
                
            string asteriskoak = "";
            for (int i = 0; i < pasahitza.Length; i++)
            {
                asteriskoak += "*";
            }
            Console.WriteLine($"PASAHITZA: {asteriskoak}");
        }
            
        Console.WriteLine($"MOTA: {mota}");
    }
    public string FormatoaFitxategia1()
    {
        return $"{plataforma},{erabiltzailea},{pasahitza},{mota}";
    }
}
