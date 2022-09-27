using System;
using System.Collections.Generic;

namespace RPG;

public class Inventory{

    //Se crean dos listas, una para el arsenal del personaje, otro para su ropaje.
    //Así, al momento de atacar solo se muestran los items que sirven para esto y no, por ejemplo, una túnica.
    //Como uno puede resolver cualquier tipo de item, se utiliza la interfaz, en cambio para el otro, solo la clase Gear
    public List<Gear> CharacterGear;
    public List<IItem> CharacterWeaponry;

    public Equipment Equipment{get;set;}
    
    public Inventory(Equipment equipment)
    {
        this.CharacterGear = new List<Gear>();
        this.CharacterWeaponry = new List<IItem>();
        this.Equipment = equipment;
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


    public int GetAttackValue(){
        int attackValue=0;
        if (this.Equipment.LeftArm != null)
        {
            attackValue += this.Equipment.LeftArm.AttackValue;
        }
        if (this.Equipment.RightArm != null)
        {
            attackValue += this.Equipment.RightArm.AttackValue;
        }
        return attackValue;
    }

    public int GetDefenseValue(){
        int defenseValue=0;
        if (this.Equipment.LeftArm != null)
        {
            defenseValue += this.Equipment.LeftArm.DefenseValue;
        }
        if (this.Equipment.RightArm != null)
        {
            defenseValue += this.Equipment.RightArm.DefenseValue;
        }
        if (this.Equipment.Armor != null)
        {
            defenseValue += this.Equipment.Armor.DefenseValue;
        }

        return defenseValue;
    }


    // * Metodos para Equipar y desequipar las armas y atuendos.
    // ! se deberian colocar estos metodos dentro de la clase Equipment
    public void EquipRightArm(IItem weapon)
    {
        if (CharacterWeaponry.Contains(weapon))
        {
            this.Equipment.RightArm = weapon;
        }
        else
        {
            Console.WriteLine("No posees este arma en el inventario");
        }

    }

    public void EquipLeftArm(IItem weapon)
    {
        if (CharacterWeaponry.Contains(weapon))
        {
            this.Equipment.LeftArm = weapon;
        }
        else
        {
            Console.WriteLine("No posees esta arma en el inventario.");
        }

    }

    public void EquipArmor(Protection armor)
    {
        if (CharacterWeaponry.Contains(armor))
        {
            this.Equipment.Armor = armor;
        }
        else
        {
            Console.WriteLine("No posees este atuendo en el inventario.");
        }
    }
    public void UnEquipRightArm(IItem weapon)
    {
        this.Equipment.RightArm = null;

    }
    public void UnEquipLeftArm(IItem weapon)
    {
        this.Equipment.LeftArm = null;

    }
    public void UnEquipArmor()
    {
        this.Equipment.Armor = null;
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