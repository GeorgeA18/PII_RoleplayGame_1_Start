using System;

namespace RPG;

public interface ICharacter{
    string Name{get;set;}
    int Health{get;set;}
    Inventory Inventory {get; set;}
    int AttackValue();
    int DefenseValue();
    void Attack(ICharacter character, IItem Item);
    void ReceiveAttack(IItem item);
    void Cure(int healing);

}