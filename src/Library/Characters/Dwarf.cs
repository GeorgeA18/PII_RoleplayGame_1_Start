//Se deben cambiar los Console.WriteLine por returns de strings, para poder imprimirlo desde donde sea, y no violar SRP
using System;

namespace RPG;

public class Dwarf : ICharacter{
    public string Name{get;set;}
    public Equipment Equipment { get; set; }
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}
    public int DefaultCure{get; set;}
    

    public Dwarf(string Name, int Health, Equipment equipment, int DefaultCure){
        
        this.Name=Name.Trim();
        this.Health = Health;
        this.Equipment = equipment;
        this.DefaultCure = DefaultCure;
        this.DefenseValue = this.Equipment.GetDefenseValue();
        this.AttackValue = this.Equipment.GetAttackValue();
        this.ValidationAttributes();
    } 
    public void Attack(ICharacter character)
    {
        if (this.Equipment.RightArm != null || this.Equipment.LeftArm != null)
        {
            if (character.Health + character.DefenseValue > this.AttackValue)
            {
                character.Health -= (this.AttackValue - character.DefenseValue);
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
    public void Cure(ICharacter character){
        if(character.Health+DefaultCure < 100){
            character.Health+=DefaultCure;
            Console.WriteLine($"{this.Name} Cure {DefaultCure} and now their health is {character.Health}");
        }
        else
        {
            character.Health=100;
        }
    }
    public void SubmitCharacter()
    {
        Console.WriteLine($"\nName: -|{this.Name}|-");
        Console.WriteLine($"Health: -|{this.Health}|-");
        Console.WriteLine("-|Dwarf|-");
        
    }
    public void ValidationAttributes()
    {
        ValidationCharacter Validator = new ValidationCharacter(this);
        Validator.ParameterReview();
    }
}