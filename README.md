Bezero Kontuen Kudeatzailea v2.0 🔐
Kontu kudeaketarako sistema aurreratua C#-n
Programazio Orientatua Objektuetara - Proiektu Akademikoa

📊 Edukia
🆚 V1 vs V2 Aldeak

🎯 Proiektuaren Helburuak

🏗️ Arkitektura

⚙️ Teknologia eta Kontzeptuak

📁 Fitxategi Egitura

✨ Ezaugarriak

🚀 Nola Exekutatu

📈 Kodearen Estatistikak

🎓 Ikasitakoa

🔮 Etorkizuneko Hobekuntzak

🆚 V1 vs V2 Aldeak
Ezaugarria	V1 (Hasierakoa)	V2 (Gaurkoa)
Arkitektura	Monarkikoa (1 fitxategi)	Multi-fitxategikoa (POO)
Datu egiturak	Array bidimentsionala	List<T> eta Dictionary
Memoria kudeaketa	Estatikoa (50 elementu)	Dinamikoa (mugarik gabe)
Kode lerroak	~300	~750+
Modularitatea	Baxua (guztia Main-en)	Altua (8 klase banatuta)
Akatsen kudeaketa	Oinarrizkoa	Try-catch eta balidazioak
Datu gordetzea	Memorian bakarrik	Inportatu/Esportatu fitxategiak
Estatistikak	Ez zegoen	Dictionary erabiliz
✅ V1-tik mantendu dena:
Kontsolako interfaze erraza

Funtzio nagusiak: sortu, ikusi, bilatu kontuak

Sarrera balidazio oinarriak

Pasahitz kudeaketa (izarrekinekin)

🔄 V2-n hobetu dena:
Antolaketa: 1-tik 8 fitxategira

Eskalagarritasuna: Zerrenda dinamikoak vs array estatikoa

Datu analisia: Estatistika sistema osoa

Datu iraunkortasuna: Gordeta/berreskuratuta fitxategietatik

Segurtasuna: Pasahitz indarraren analisia

🎯 Proiektuaren Helburuak (PDF-tik)
✅ Betetako Helburuak:
1. Programazio Orientatua Objektuetara
csharp
// Inplementatuta:
- Kontua.cs (oinarrizko klasea)
- Zerrenda.cs (kolekzioen kudeaketa)
- Estatistikak.cs (datuen analisia)
2. Modularitatea
8 klase fitxategi banatutan

Metodoak erantzukizun bakarrarekin

Antolatutako namespace: Proiektua

3. Kontrol Egiturak
if/else, switch, for, while

Erabiltzaile sarreren balidazioa

Menu interaktiboak

4. Datu Egiturak (PDF 27-30 orrialdeak)
List<T>: Kontuen kudeaketa dinamikoa

Dictionary<K,V>: Estatistikak motaren/plataformaren arabera

Array[]: Aurrez definitutako kontu motak

5. Gelan Ikusitako Sintaxia
0 sintaxi berri: Apunteetan ikusitakoa bakarrik

Eraikitzaileak: Objektuen hasieraketa

Getters/Setters: Enkapsulazioa (16-17 orrialdeak)

Metodo estatikoak: Oinarrizko utilitateak

6. Mantentzeko Kodea
Azalpen iruzkinak

Izen deskriptiboak (euskara/ingelesa)

Funtzionalitatearen araberako banaketa

7. Iruzkinak eta Kontestu Erreala
Kontu kudeaketa errealerako proiektua

Kodearen dokumentazioa

Erabilera kasu praktikoak

🏗️ Arkitektura
text
┌─────────────────────────────────────────────────────────┐
│                 PROGRAM.CS (Orkestratzailea)            │
│  • Menu nagusia                                         │
│  • Fluxu kontrola                                       │
│  • Klaseen koordinazioa                                 │
└─────────────────┬───────────────────────────────────────┘
                  │
    ┌─────────────┼─────────────┐
    │             │             │
┌───▼────┐  ┌────▼─────┐  ┌────▼──────┐
│ KONTUA  │  │ ZERRENDA │  │ESTATISTIKAK│
│ (Modeloa)│ │ (List)   │  │(Dictionary)│
└─────────┘  └──────────┘  └───────────┘
    │             │             │
    └─────────────┼─────────────┘
                  │
           ┌──────▼──────┐
           │   DATUAK    │
           │ (Konstanteak)│
           └─────────────┘
⚙️ Teknologia eta Kontzeptuak
C# eta .NET
Hizkuntza: C# 8.0+

Frameworka: .NET Core 6.0+

IDE: Visual Studio Code / Visual Studio

Programazio Paradigmak
Objektuetara Orientatua (Nagusia)

Enkapsulazioa

Abstrakzioa

Modularitatea

Egituratua (Bigarren maila)

Funtzioak eta prozedurak

Fluxu kontrol egituratua

Datu Egiturak
Egitura	Proiektuan erabilera	Apunte Orria
List<T>	Kontuak gordetzeko	27 orria
Dictionary<K,V>	Estatistikak	28-30 orriak
Array[]	Aurrez definitutako motak	Ikastaro osoa
string	Testu manipulazioa	Oinarrizkoa
System.IO (Oinarrizkoa)
csharp
// 3 metodo soilik erabili (apunteetan bezala):
File.Exists()      // Fitxategia egiaztatu
File.ReadAllLines() // Fitxategia irakurri
File.WriteAllText() // Fitxategia idatzi
📁 Fitxategi Egitura
bash
Proiektua/
├── 📄 Program.cs              # Menu nagusia eta kontrola
├── 📄 kontua.cs               # Kontua klasea (modeloa)
├── 📄 zerrenda.cs             # List<Kontua> kudeaketa
├── 📄 estatistikak.cs         # Estatistikak Dictionary-rekin
├── 📄 segurtasuna.cs          # Segurtasun analisia
├── 📄 fitxategiak_kudeatu.cs  # Inportatu/Esportatu
├── 📄 datuak.cs               # Datuak konstanteak
└── 📄 .csproj                 # Proiektu konfigurazioa
Erantzukizunak:
Program.cs: Orkestratzailea, menuak, fluxua

kontua.cs: Entitate nagusia, propietateak

zerrenda.cs: Kontuen CRUD

estatistikak.cs: Metrika eta analisia

segurtasuna.cs: Pasahitz balidazioa

fitxategiak_kudeatu.cs: Iraunkortasuna

datuak.cs: Konfigurazioa eta konstanteak

✨ Ezaugarriak
1. Kontu Kudeaketa Osoa ✅
Sortzea balidazioarekin

Bilaketa plataformaren arabera

Formateatutako bistaratzea

Ezabatzea bakarka/multzoka

2. Estatistika Sistema ✅
Kontaketa kontu motaren arabera

Banaketa plataformaren arabera

Metrika denbora errealean

Dictionary erabilera eraginkorra

3. Segurtasuna ✅
Pasahitz ezkutaketa

Indarraren analisia

Pasahitz ahulak detektatzea

Segurtasun gomendioak

4. Datu Iraunkortasuna ✅
CSV-tik inportatzea

Testu lauko fitxategira esportatzea

Formatu estandar bateragarria

Backup automatikoa

5. Erabiltzaile Interfazea ✅
Menu hierarkikoak

Nabigazio intuitiboa

Erabiltzaileari feedback argia

Bistaratze bisual atsegina

🚀 Nola Exekutatu
Aurreko Baldintzak
bash
# 1. .NET SDK instalatuta edukitzea
dotnet --version  # 6.0 edo gorago erakutsi behar du

# 2. Kode editorea (aukerakoa)
#    - Visual Studio Code
#    - Visual Studio
#    - JetBrains Rider
Konpilatu eta Exekutatu
bash
# Metodo 1: .NET CLI-rekin
dotnet build     # Konpilatu
dotnet run       # Exekutatu

# Metodo 2: Konpilazio zuzena
mcs -out:program.exe *.cs  # Linux/Mac
csc -out:program.exe *.cs  # Windows
./program.exe              # Exekutatu
Erabilera Adibidea
text
1. Kontu berria sortu
2. Inportatu "kontuak.txt"-tik
3. Ikusi estatistikak motaren arabera
4. Esportatu backup-a
5. Analizatu pasahitzen segurtasuna
📈 Kodearen Estatistikak
Metrika	Balioa	Oharra
.cs fitxategiak	8	Arkitektura modularra
Kode lerroak	~750	Proiektu substantziala
Klaseak	6	POO diseinu ona
Metodoak	~45	Funtzionalitate osoa
Iruzkinak	~150	Ongi dokumentatuta
Kode/iruzkin erlazioa	5:1	Bikaina
Konplexutasun Ziklo-matiko
Baxua: Metodo sinple eta fokaturik

Ertaina: Bilaketa/iragazki algoritmoak

Altua: Menu interaktiboak (kontrolatuta)

🎓 Ikasitakoa
Teknikoa
POO Diseinua: Erantzukizunen banaketa

C# Kolekzioak: List vs Dictionary vs Array

Fitxategi kudeaketa: Sarrera/Irteera oinarrizkoa

Datu balidazioa: Sendoa erabiltzaile sarreretan

Debugging: Salbuespen ohikoen kudeaketa

Metodologikoa
Refactorizazioa: Kodearen hobekuntza inkremental

Bertsionatzea: Aldaketen kontrola (Git)

Dokumentazioa: Iruzkin erabilgarriak

Probak: Probaketa eskuz zehatzak

Presentazioa: Erabiltzaile interfaze argia

Aurreko Proiektutik
✅ Mantenduta: Sistemaaren esentzia

✅ Hobetuta: Arkitektura eta eskala daitezkortasuna

✅ Gehituta: Estatistikak eta iraunkortasuna

✅ Leunduta: Erabiltzaile esperientzia

🔮 Etorkizuneko Hobekuntzak
Lehentasun Altua
Bilaketa aurreratua: Iragazki konbinatuak

Enkriptazio oinarrizkoa: Pasahitzak fitxategietan

Logging: Jardueren erregistroa

Proba unitarioak: Balidazio automatikoa