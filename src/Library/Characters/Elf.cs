using System;

namespace RPG;
public class Elf : ICharacter{
    //Se tiene que poner que calcule el ataque/defensa, iterando en cada lista del inventario, para solo los ítems que no sean mágicos
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

    public Elf(string Name, Inventory Inventory, int Health, int AttackValue, int DefenseValue){
        this.Name=Name;
        this.Inventory=Inventory;
        this.Health = Health;
    }
    public void Attack(ICharacter character, IItem item){

    }
    public void ReceiveAttack(IItem item){

    }
    public void Cure(int healing){

    }
}