
namespace RPG;

// Se crea la interfaz IMagicItem para luego implementar el tipo en las clases WizardItem y SpellBook, 
// las cuales comparten las variables de instancia y método a continuación. Ésta se diferencia de IItem ya
// que únicamente personajes de la clase Wizard pueden utilizar ítems mágicos, por lo que es pertinente
// designarles un tipo diferente. 

public interface IMagicItem{

    // Se establecen las variables de instancia accesibles para que sea posible instanciar más de un 
    // ítem de cada clase.

    string Name {get; set;}
    int AttackValue {get; set;}
    int DefenseValue {get; set;}
    int CureValue{get; set;}
    public void DefaultName();
}