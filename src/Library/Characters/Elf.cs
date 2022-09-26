using System;

namespace RPG;
public class Elf : ICharacter{
    public string Name{get;set;}
    public Inventory Inventory {get; set;}
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}
    public int DefaultCure{get;set;}

    public Elf(string Name, int Health, Inventory inventory, int DefaultCure){

        this.Name=Name;
        this.Health = Health;
        this.Inventory= inventory;
        this.AttackValue = this.Inventory.GetAttackValue();
        this.DefenseValue = this.Inventory.GetDefenseValue();
        this.DefaultCure = DefaultCure;

    } 
    public void Attack(ICharacter character, IItem item){

        //Falta integrar el defense value

        if (this.Inventory.CharacterWeaponry.Contains(item))
        {
            if (character.Health + character.DefenseValue > item.AttackValue )
            {
                character.Health -= (item.AttackValue-character.DefenseValue);
                Console.WriteLine($"{this.Name} attacked {character.Name} with {item} and now their health decreased to {character.Health}.");
            }
            else
            {
                character.Health = 0;
                Console.WriteLine($"{this.Name} attacked {character.Name} with {item} and killed them.");
            }
        }  
        else
        {
            Console.WriteLine($"You do not have that item!");
        }

    }
    public void Cure(ICharacter character){
        character.Health+=DefaultCure;
        Console.WriteLine($"{this.Name} Cure {DefaultCure} and now their health is {Health}");
    }

    public void SubmitCharacter()
    {
        Console.WriteLine($"\nName: -|{this.Name}|-");
        Console.WriteLine($"Health: -|{this.Health}|-");
        Console.WriteLine("-|Elf|-");
    }

}
