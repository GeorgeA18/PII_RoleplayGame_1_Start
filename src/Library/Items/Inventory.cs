using System.Collections.Generic;
public class Inventory{
    /// Habría que poner un método que devuelva el inventario de manera bonita, prontito para imprimir donde se quiera
    /// Que ponga tanto los items como sus estadísticas
    /// También que se devuelva la suma de los valores de ataque / defensa para los metodos de los personajes

    //Se crean dos listas, una para el arsenal del personaje, otro para su ropaje.
    //Así, al momento de atacar solo se muestran los items que sirven para esto y no, por ejemplo, una túnica.
    //Como uno puede resolver cualquier tipo de item, se utiliza la interfaz, en cambio para el otro, solo la clase Gear
    List<IItem> CharacterWeaponry = new List<IItem>();
    List<Gear> CharacterGear = new List<Gear>();

    void AddGear(Gear gear){
        CharacterGear.Add(gear);
    }
    void RemoveGear(Gear gear){
        CharacterGear.Remove(gear);
    }

    void AddWeaponry(IItem weaponry){
        CharacterWeaponry.Add(weaponry);
    }
    void RemoveWeaponry(IItem weaponry){
        CharacterWeaponry.Add(weaponry);
    }

    
}