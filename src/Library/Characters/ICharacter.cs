using System;

namespace RPG;

public interface ICharacter{
    string Name{get;set;}
    int Health{get;set;}
    Inventory Inventory {get; set;}
    int AttackValue{get;}
    int DefenseValue{get;}
    int DefaultCure{get;set;}
    void Attack(ICharacter character, IItem Item);
    void Cure(ICharacter character);

    // Metodo para presentar la infromación de personaje.
    // void SubmitCharacter();

}