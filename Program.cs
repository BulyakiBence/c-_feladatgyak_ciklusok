
using System.ComponentModel.Design;

Console.Write("Add meg az életkorod: ");
int eletkor = Convert.ToInt32(Console.ReadLine());
int nagykoru = 18;
if  (eletkor < nagykoru)
{
    Console.WriteLine("A felhasználó még kiskorú"); 
}
    else
{
    Console.WriteLine("A felhasználó mmár nagykorú");
}


// 2. feladat
Console.Write("Adj meg egy egész számot: ");
int egesz = Convert.ToInt32(Console.ReadLine());
if (egesz % 2 == 0) 
{
    Console.WriteLine("A szám páros"); 
}
else
{
    Console.WriteLine("A szám páratlan");
}

// 3. feladat
Console.Write("Adj meg egy jelszót: ");
string jelszo = Console.ReadLine();
string helyes = "tengerpart";
if  (jelszo == helyes)

{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("A jelszó helyes"); }
else
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("A jelszó helytelen");
}
Console.ResetColor();

// 4. feladat

Console.Write("Mekkora értékben rendeltél: ");
int osszeg = Convert.ToInt32(Console.ReadLine());
const  int  SZALL_DIJ = 1490;
int min = 15000;
if (osszeg >= min)
{ Console.WriteLine($"A szállítási díj 0 ft; a rendelésed összege {osszeg:N0} ft "); }

else
{

    Console.WriteLine($"A szállítási díj {SZALL_DIJ:N0} ft, a rendelés értéke {osszeg:N0} ft");
}

// 5. feladat
Console.Write("Adj megy egy számot: ");
double szam1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Adj meg egy másik számot: ");
double szam2 = Convert.ToDouble(Console.ReadLine());

if (szam1 > szam2)
{ 
    double kulonbseg1 = szam1 - szam2;
    Console.WriteLine($"Az első szám nagyobb, ennyivel {kulonbseg1} ");
}
else if (szam1 == szam2)
{
    Console.WriteLine("A két szám egyenlő");

}
else
{
    double kulonbseg2 = szam2 - szam1;
    Console.WriteLine($"A második szám nagyobb, ennyivel {kulonbseg2} ");

}


// 6. feladat
Console.Write("Adj meg egy egész számot: ");
string valasz = Console.ReadLine();
bool sikeres = int.TryParse(valasz, out int egesz_szam );

if (sikeres)
{
    int ketszeres = egesz_szam * 2;
    int negyzet = egesz_szam * egesz_szam;
    Console.WriteLine($"A szám kétszerese {ketszeres}, a négyzete {negyzet} ");
}
else
{
    Console.WriteLine("Nem egész számot adtál meg");
}


// 7. feladat

Console.Write("Hány fok van kint: ");
double homerseklet = Convert.ToDouble(Console.ReadLine());

if (homerseklet < 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("A hőmérséklet nulla fok alatt van");
}

else if (homerseklet < 15)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Hűvös van");

}

else if (homerseklet < 25)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Kellemes az idő");
}

else if (homerseklet >= 25)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Meleg van");
    Console.ResetColor();


}

Console.ResetColor();
// 8.feladat

Console.Write("Adj meg egy osztályzatot számmal: ");
string osztaly = Console.ReadLine();
if (osztaly == "1")
{

    Console.WriteLine("A jegy elégtelen");
}
else if (osztaly == "2")
{

    Console.WriteLine("A jegy elégséges");
}

else if (osztaly == "3")

{

    Console.WriteLine("A jegy közepes");
}

else if (osztaly == "4")
{

    Console.WriteLine("A jegy jó");

}

else if (osztaly == "5")
{

    Console.WriteLine("A jegy jeles");
}
else 
    {
    Console.WriteLine("Nem számot adtál meg");
}


// 9.feladat

Console.Write("Írd be az elért pontszámot: ");
double pontszám = Convert.ToDouble(Console.ReadLine());

if (pontszám < 39)
{
    Console.WriteLine("A jegyed elégtelen");

}
else if (pontszám < 54)
{

    Console.WriteLine("A jegyed elégséges");
}

else if (pontszám < 69)

{
    Console.WriteLine("A jegyed közepes");
}

else if (pontszám < 84) 

{

    Console.WriteLine("A jegyed jó");
}

else if (pontszám < 100)
{

    Console.WriteLine("A jegyed jeles");
}
else
{
    Console.WriteLine("0 és 100 közöt adj meg számot");
}


// 10. feladat
Console.Write("Írd be a hónap sorszámát: ");
int honap = Convert.ToInt32(Console.ReadLine());
if ()

