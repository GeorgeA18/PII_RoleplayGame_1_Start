using System;

namespace RPG;

public class Dwarf : ICharacter{
    //Se tiene que poner que calcule el ataque/defensa, iterando en cada lista del inventario, solo de los ítems que no sean mágicos
    //Attack, Cure, ReceiveAttack todavía no tienen código
    public string Name{get;set;}
    public Inventory Inventory {get; set;}
    public int Health{get;set;}
    public int AttackValue(){
        int attackValue=0;
        /*
        foreach(IItem item in this.CharacterWeaponry){
            attackValue+=item.AttackValue;
        }
        */
        return attackValue;
    }
    public int DefenseValue(){
        int defenseValue=0;
        /*
        foreach(IItem item in this.CharacterWeaponry){
            defenseValue+=item.DefenseValue;
        }
        */
        return defenseValue;
    }

    public Dwarf(string Name, Inventory Inventory, int Health, int AttackValue, int DefenseValue){
        this.Name=Name;
        this.Inventory=Inventory;
        this.Health = Health;
    }

    public void Attack(ICharacter character, IItem Item){

    }
    public void ReceiveAttack(IItem Item){

    }
    public void Cure(int healing){

    }
}