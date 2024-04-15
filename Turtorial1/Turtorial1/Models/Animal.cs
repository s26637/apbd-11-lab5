using System.Runtime.InteropServices.JavaScript;

namespace Turtorial1.Models;

public class Animal
{
    public int id { get; set;}
    public string imie { get; set;}
    public string kategoria { get; set;}
    public double masa { get; set;}
    public string kolor { get; set;}
    
    List<Wizyta> listaWizyt = new List<Wizyta>();
    public Animal(int id, string imie, string kategoria, double masa, string kolor)
    {
        this.id = id;
        this.imie = imie;
        this.kategoria = kategoria;
        this.masa = masa;
        this.kolor = kolor;
    }

    public string pokazListeWizyt()
    {
        string wynik = "";
        foreach (Wizyta l in listaWizyt)
        {
          
            wynik += l.id + ", " + l.data + ", " + l.cena + ", " + l.opis + "\n";
        }
        return wynik;
    }

    public void dodajWizyte(string data, int id, string opis, double cena)
    {
        listaWizyt.Add(new Wizyta{data = data, id = id, opis = opis, cena = cena});
    }
}

class Wizyta
{
   
    public string data { get; set;}
    public int id { get; set;}
    public string opis { get; set;}
    public double cena { get; set;}
    
    
}