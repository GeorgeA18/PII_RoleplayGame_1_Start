using System;

namespace RPG;

public class Dwarf : ICharacter{
    //Se tiene que poner que calcule el ataque/defensa, iterando en cada lista del inventario, solo de los ítems que no sean mágicos
    //Attack, Cure, ReceiveAttack todavía no tienen código
    public string Name{get;set;}
    public Inventory Inventory {get; set;}
    public int Health{get;set;}
    public int AttackValue{get;}
    public int DefenseValue{get;}
    public int GetAttackValue(){
        int attackValue=0;
        /*
        foreach(IItem item in this.CharacterWeaponry){
            attackValue+=item.AttackValue;
        }
        */
        return attackValue;
    }
    public int GetDefenseValue(){
        int defenseValue=0;
        /*
        foreach(IItem item in this.CharacterWeaponry){
            defenseValue+=item.DefenseValue;
        }
        */
        return defenseValue;
    }

    public Dwarf(string Name, int Health, Inventory inventory){
        
        this.Name=Name;
        this.Health = Health;
        this.Inventory=Inventory;
        //this.AttackValue -> invocar método
        //this.DefenseValue -> invocar método
    } 
    public void Attack(ICharacter character, IItem item){

        //Falta integrar el defense value

        if (this.CharacterWeaponry.Contains(item))
        {
            if (character.Health > item.AttackValue + character.DefenseValue)
            {
                character.Health -= item.AttackValue;
                Console.WriteLine($"{this.Name} attacked {character.Name} with {item} and now their health decreased to {character.Health}.");
            }
            else
            {
                character.Health = 0;
                Console.WriteLine($"{this.Name} attacked {character.Name} with {item} and killed them.");
            }
        }  
        else
        {
            Console.WriteLine($"You do not have that item, dumb bitch!");
        }

    }

    public void Cure(int healing){

        this.Health += healing;

    }

    }