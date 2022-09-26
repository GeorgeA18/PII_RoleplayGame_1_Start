using System;

namespace RPG;

public class Wizard : ICharacter{
    public string Name{get;set;}
    public Inventory Inventory {get;set;}
    public SpellBook SpellBook {get;set;}
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}
    public int DefaultCure{get; set;}
    public int CureValue{get;set;}
    public Wizard(string Name, int Health, Inventory inventory, SpellBook spellBook, int defaultCure){

        this.Name= Name.Trim();
        this.Health = Health;
        this.Inventory= inventory;
        this.SpellBook = spellBook;
        this.DefaultCure = defaultCure;
        this.CureValue = DefaultCure+this.SpellBook.GetSpellBookCure();
        this.AttackValue = this.Inventory.GetAttackValue() + this.SpellBook.GetSpellBookAttack();
        this.DefenseValue = this.Inventory.GetDefenseValue()+ this.SpellBook.GetSpellBookDefense();
        this.ValidationAttributes();
    } 
    public void Attack(ICharacter character, IItem item){



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
        character.Health=CureValue;
        Console.WriteLine($"{this.Name} Cure {DefaultCure} and now their health is {character.Health}");
    }

    public void ValidationAttributes()
    {
        ValidationCharacter Validator = new ValidationCharacter(this);
        Validator.ParameterReview();
    }

    public void SubmitCharacter()
    {
        Console.WriteLine($"\nName: -|{this.Name}|-");
        Console.WriteLine($"Health: -|{this.Health}|-");
        Console.WriteLine("-|Wizard|-");
    }
}
    