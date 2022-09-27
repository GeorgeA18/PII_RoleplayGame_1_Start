using System;

namespace RPG;

public interface ICharacter{
    string Name{get;set;}
    int Health{get;set;}
    Equipment Equipment {get; set;}
    int AttackValue{get;}
    int DefenseValue{get;}
    int DefaultCure{get;set;}
    void Attack(ICharacter character);
    void Cure(ICharacter character);
    void SubmitCharacter();
    void ValidationAttributes();

}