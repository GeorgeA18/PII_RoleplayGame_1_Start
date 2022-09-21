using System.Collections.Generic;
public class Inventory{
    List<IItem> CharacterInvetory = new List<IItem>();
    void AddGear(Gear gear){
        CharacterInvetory.Add(gear);
    }
    void RemoveGear(Gear gear){
        CharacterInvetory.Remove(gear);
    }

    void AddWeapon(Weapon weapon){
    
    }
    void RemoveWeapon(Weapon weapon){
        
    }
}