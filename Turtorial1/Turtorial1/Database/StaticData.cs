using Turtorial1.Models;

namespace Turtorial1.Database;

public class StaticData
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal(1, "Maciek", "Kot", 3.5, "Czarny"),
        new Animal(2, "Paweł", "Pies", 15.2, "Biały"), 
        
        
    };

    public static Animal getAnimalUsingId(int id)
    {
        Animal animalSzukany = null;
        foreach (var animal in Animals)
        {
            if (animal.id == id)
            {
                animalSzukany =  animal;
            }
        }

        return animalSzukany;
    }

    public static void dodajWizyte(string data, int id, string opis, double cena)
    {
        foreach (var animal in Animals)
        {
            if (animal.id == id)
            {
                animal.dodajWizyte(data, id, opis, cena);
            }
            
        }
    }

    public static string listaWizyt(int id)
    {
        foreach (var animal in Animals)
        {
            if (animal.id == id)
            {
                return animal.pokazListeWizyt();
            }
        }

        return null;
    }
    
    public static void deleteAnimalUsingId(int id)
    {
        Animal animal1 = null;
        foreach (var animal in Animals)
        {
            if (animal.id == id)
            {
                animal1 = animal;
            }
            
        }

        if (animal1 != null)
        {
            Animals.Remove(animal1);
        }
    }
    
}