using System.Collections.Generic;
public class Spellbook : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}

    public Spellbook(string Name, int AttackValue, int DefenseValue){
        this.Name=Name;
        this.AttackValue=this.GetSpellBookAttack();
        this.DefenseValue=this.GetSpellBookDefense();
        this.Magic=true;
    }
    List<Spell> CharacterSpellBook = new List<Spell>();

    void AddSpell(Spell spell){
        CharacterSpellBook.Add(spell);
    }
    void RemoveSpell(Spell spell){
        CharacterSpellBook.Remove(spell);
    }

    int GetSpellBookAttack(){
        int value=0;
        foreach(Spell spell in this.CharacterSpellBook){
            value+=spell.AttackValue;
        }
        return value;
    }

    int GetSpellBookDefense(){
        int value=0;
        foreach(Spell spell in this.CharacterSpellBook){
            value+=spell.DefenseValue;
        }
        return value;
    }
}