using System;

namespace RPG;

public class ValidationWizard : IValidationCharacters
{
    // Aqui se guarda el personaje a validar.
    public ICharacter Character { get; set; }

    // Cosntructor
    public ValidationWizard(ICharacter character)
    {
        this.Character = character;
    }
    // Este metodo controla a los demas.
    public void ParameterReview()
    {
        this.NameReview(this.Character.Name);
        this.HealthReview(this.Character.Health);
        this.HealthReview(this.Character.DefaultCure);
    }

    // Verifica que el nombre no este vacio o sea invalido. * * Listo
    public void NameReview(string name)  // * * Listo
    {
        if (string.IsNullOrEmpty(name))
        {
            this.Character.Name = "Sin Nombre";
        }
    }

    // revisa si el valor del rango esta dentro de los limites (1-->500).
    public void HealthReview(int health) // * * Listo
    {
        if (health <= 0 || health > 300)
        {
            this.Character.Health = 100;
        }
    }
    // revisa si el valor del rango esta dentro de los limites (1-->100).
    public void DefaultCureReview(int cureValue)
    {
        if (cureValue < 1 || cureValue > 60)
        {
            this.Character.DefaultCure = 20;
        }
    }


}


/*
public class Wizard : ICharacter{
    public string Name{get;set;}
    public Inventory Inventory {get;set;}
    public SpellBook SpellBook {get;set;}
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}
    public int DefaultCure{get; set;}
    public int CureValue{get;set;}

    public Wizard(string Name, int Health, Inventory inventory, SpellBook spellBook, int DefaultCure){

        this.Name= Name;
        this.Health = Health;
        this.Inventory= inventory;
        this.SpellBook = spellBook;
        this.CureValue = DefaultCure+this.SpellBook.GetSpellBookCure();
        this.AttackValue = this.Inventory.GetAttackValue() + this.SpellBook.GetSpellBookAttack();
        this.DefenseValue = this.Inventory.GetDefenseValue()+ this.SpellBook.GetSpellBookDefense();
    } 


*/