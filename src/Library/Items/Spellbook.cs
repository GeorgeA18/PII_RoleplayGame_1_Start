using System.Collections.Generic;
namespace RPG;
public class SpellBook : IItem{
    //Faltaría un método para mostrar los spells del libro

    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}

    public SpellBook(string Name){
        this.Name=Name;
        //Con GetSpellBookAttack se itera sobre los hechizos de SpellBook para poder así calcular el poder de ataque del libro
        this.AttackValue=this.GetSpellBookAttack(); 
        //Idem que con el ataque, pero para la defensa
        this.DefenseValue=this.GetSpellBookDefense();
        this.Magic=true; //Como el spellbook es un ítem mágico por defecto, Magic siempre es true
    }
    List<Spell> CharacterSpellBook = new List<Spell>();

    void AddSpell(Spell spell){
        CharacterSpellBook.Add(spell);
    }
    void RemoveSpell(Spell spell){
        CharacterSpellBook.Remove(spell);
    }

    public int GetSpellBookAttack(){
        int value=0;
        foreach(Spell spell in this.CharacterSpellBook){
            value+=spell.AttackValue;
        }
        return value;
    }

    public int GetSpellBookDefense(){
        int value=0;
        foreach(Spell spell in this.CharacterSpellBook){
            value+=spell.DefenseValue;
        }
        return value;
    }
}