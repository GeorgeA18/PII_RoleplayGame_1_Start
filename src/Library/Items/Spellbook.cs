using System.Collections.Generic;
using System;

namespace RPG;
public class SpellBook : IItem{
    //Faltaría un método para mostrar los spells del libro. Nota: esta creada pero falta verficar que funcione.

    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public int CureValue{get;set;}
    public bool Magic{get; set;}
    public List<Spell> CharacterSpellBook = new List<Spell>();

    public SpellBook(string Name){
        this.Name=Name;
        //Con GetSpellBookAttack se itera sobre los hechizos de SpellBook para poder así calcular el poder de ataque del libro
        this.AttackValue=this.GetSpellBookAttack(); 
        //Idem que con el ataque, pero para la defensa
        this.DefenseValue=this.GetSpellBookDefense();
        this.CureValue=this.GetSpellBookCure();
        this.Magic=true; //Como el spellbook es un ítem mágico por defecto, Magic siempre es true
    }

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

    public int GetSpellBookCure(){
        int value=0;
        foreach(Spell spell in this.CharacterSpellBook){
            value+=spell.CureValue;
        }
        return value;
    }

    // ! Verificar que funcione.
    public void PrintSpellBook(ICharacter wizard){

        Console.WriteLine($"{wizard.Name}'s SPELLBOOK SUMMARY");
        Console.WriteLine("Spells list:");
        foreach(Spell spell in this.CharacterSpellBook){
            Console.WriteLine($"{spell} | Attack : {spell.AttackValue} | Defense : {spell.DefenseValue} | Cure : {spell.CureValue}");
        }

    }
}
