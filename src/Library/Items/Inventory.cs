using System;
using System.Collections.Generic;

namespace RPG;

public class Inventory{

    //Se crean dos listas, una para el arsenal del personaje, otro para su ropaje.
    //Así, al momento de atacar solo se muestran los items que sirven para esto y no, por ejemplo, una túnica.
    //Como uno puede resolver cualquier tipo de item, se utiliza la interfaz, en cambio para el otro, solo la clase Gear
    public List<Gear> CharacterGear;
    public List<IItem> CharacterWeaponry;
    
    public Inventory(Equipment equipment)
    {
        this.CharacterGear = new List<Gear>();
        this.CharacterWeaponry = new List<IItem>();
    }

    public void AddGear(Gear gear){
        CharacterGear.Add(gear);
    }
    public void RemoveGear(Gear gear){
        CharacterGear.Remove(gear);
    }

    public void AddWeaponry(IItem weaponry){
        CharacterWeaponry.Add(weaponry);
    }
    public void RemoveWeaponry(IItem weaponry){
        CharacterWeaponry.Add(weaponry);
    }


    


    // * Metodo de Presentación de los items
    public void PrintInventory(ICharacter character){

        Console.WriteLine($"{character.Name}'s INVENTORY SUMMARY");
        Console.WriteLine("Items:");
        foreach(IItem item in this.CharacterWeaponry){
            Console.WriteLine($"{item} | Attack : {item.AttackValue} | Defense : {item.DefenseValue}");
        }
        Console.WriteLine("Gear and accesories:");
        foreach(IItem item in this.CharacterGear){
            Console.WriteLine(item);
        }
    }
}