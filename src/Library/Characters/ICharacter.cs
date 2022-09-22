using System;

namespace RPG;

public interface ICharacter{
    string Name{get;set;}
    int Health{get;set;}
    Inventory Inventory {get; set;}
    int AttackValue{get;}
    int DefenseValue{get;}
    void Attack(ICharacter character, IItem Item);
    void Cure();

}