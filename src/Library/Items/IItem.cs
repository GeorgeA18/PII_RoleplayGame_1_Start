
namespace RPG;

// Se crea la interfaz IItem para luego implementar el tipo en las clases Gear, Protection, Weapon y DualItem 
// las cuales comparten las variables de instancia y método a continuación.
// De esta manera, podemos aplicar polimorfismo, y emplear listas que solo admitan implementaciones de la interfaz
// facilitandonos la tarea de manejar el inventario del personaje
public interface IItem{

    // Se establecen las variables de instancia accesibles para que sea posible instanciar más de un 
    // ítem de cada clase.

    string Name {get; set;}
    int AttackValue {get; set;}
    int DefenseValue {get; set;}
    public void DefaultName();
}