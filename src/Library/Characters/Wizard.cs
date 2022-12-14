//Se deben cambiar los Console.WriteLine por returns de strings, para poder imprimirlo desde donde sea, y no violar SRP
using System;

namespace RPG;

public class Wizard : ICharacter{
    public string Name{get;set;}
    public Equipment Equipment {get;set;}
    public SpellBook SpellBook {get;set;}
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}
    public int DefaultCure{get; set;}
    public int CureValue{get;set;}
    public Wizard(string Name, int Health, Equipment equipment, SpellBook spellBook,int defaultCure){

        this.Name= Name.Trim();
        this.Health = Health;
        this.Equipment= equipment;
        this.SpellBook = spellBook;
        this.DefaultCure = defaultCure;
        this.CureValue = DefaultCure+this.SpellBook.GetSpellBookCure();
        this.AttackValue = this.Equipment.GetAttackValue() + this.SpellBook.GetSpellBookAttack();
        this.DefenseValue = this.Equipment.GetDefenseValue()+ this.SpellBook.GetSpellBookDefense();
        this.ValidationAttributes();
    }
    public void Attack(ICharacter character)
    {
        if (this.Equipment.RightArm != null || this.Equipment.LeftArm != null)
        {
            if (character.Health + character.DefenseValue > this.AttackValue )
            {
                character.Health -= (this.AttackValue-character.DefenseValue);
                Console.WriteLine($"{this.Name} attacked {character.Name} and now their health decreased to {character.Health}.");
            }
            else
            {
                character.Health = 0;
                Console.WriteLine($"{this.Name} attacked {character.Name} and killed them.");
            }
        }
        else
        {
            Console.WriteLine("You do not have any weapon equipped.");
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
    