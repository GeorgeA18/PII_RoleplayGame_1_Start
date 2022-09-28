using System;

namespace RPG;

// Se crea la interfaz ICharacter para luego implementar el tipo en las clases Wizard, Dwarf y Elf las
// cuales comparten las variables de instancia y métodos a continuación.

public interface ICharacter{

    // Se establecen las variables de instancia accesibles para que sea posible instanciar más de un
    // personaje de cada clase.

    string Name{get;set;}
    int Health{get;set;}
    Equipment Equipment {get; set;}
    int AttackValue{get;}
    int DefenseValue{get;}
    int DefaultCure{get;set;}

    // Los métodos de ataque y curación son ejecutados por la clase de cada personaje ya que tienen toda la
    // información necesaria para hacerlo (principio Expert).

    void Attack(ICharacter character);
    void Cure(ICharacter character);
    void SubmitCharacter();
    void ValidationAttributes();

}