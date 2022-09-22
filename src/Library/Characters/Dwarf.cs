using System;

namespace RPG;

public class Dwarf : ICharacter{
    public string Name{get;set;}
    public Inventory Inventory {get; set;}
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}

    public Dwarf(string Name, int Health, Inventory inventory){
        
        this.Name=Name;
        this.Health = Health;
        this.Inventory= new Inventory();
        this.AttackValue = this.Inventory.GetAttackValue();
        this.DefenseValue = this.Inventory.GetDefenseValue();

    } 
    public void Attack(ICharacter character, IItem item){

        //Falta integrar el defense value

        if (this.CharacterWeaponry.Contains(item))
        {
            if (character.Health > item.AttackValue + character.DefenseValue)
            {
                character.Health -= item.AttackValue;
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
            Console.WriteLine($"You do not have that item, dumb bitch!");
        }

    }

    public void Cure(){

        this.Health = 100;

    }

    }