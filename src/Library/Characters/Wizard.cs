using System;

namespace RPG;

public class Wizard : ICharacter{
    public string Name{get;set;}
    public Inventory Inventory {get;set;}
    public SpellBook SpellBook {get;set;}
    public Equipment Equipment { get; set; }
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}
    public int DefaultCure{get; set;}
    public int CureValue{get;set;}
    public Wizard(string Name, int Health, Inventory inventory, SpellBook spellBook,int defaultCure){

        this.Name= Name.Trim();
        this.Health = Health;
        this.Inventory= inventory;
        this.SpellBook = spellBook;
        this.Equipment = Inventory.Equipment;
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

    public void MagicAttack(ICharacter character, int numHechizo){
        int dañoHechizo=this.SpellBook.CharacterSpellBook[numHechizo].AttackValue;
        string nombreHechizo= this.SpellBook.CharacterSpellBook[numHechizo].Name;
        if (character.Health + character.DefenseValue > dañoHechizo)
            {
                character.Health -= (dañoHechizo-character.DefenseValue);
                Console.WriteLine($"{this.Name} attacked {character.Name} with {nombreHechizo} and now their health decreased to {character.Health}.");
            }
            else
            {
                character.Health = 0;
                Console.WriteLine($"{this.Name} attacked {character.Name} with {nombreHechizo} and killed them.");
            }
    }
    public void Cure(ICharacter character){
        if(character.Health+CureValue < 100){
            character.Health+=CureValue;
            Console.WriteLine($"{this.Name} Cure {DefaultCure} and now their health is {character.Health}");
        }
        else
        {
            character.Health=100;
        }
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
    