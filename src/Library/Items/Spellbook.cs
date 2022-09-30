//Se deben cambiar los Console.WriteLine por returns de strings, para poder imprimirlo desde donde sea, y no violar SRP
using System.Collections.Generic;
using System;

namespace RPG;
public class SpellBook : IMagicItem{

    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public int CureValue{get;set;}
    public List<Spell> CharacterSpellBook = new List<Spell>();

    public SpellBook(string Name){
        this.Name=Name.Trim();
        //Con GetSpellBookAttack se itera sobre los hechizos de SpellBook para poder así calcular el poder de ataque del libro
        //Se conoce los valores de ataque, defensa, cura desde aquí, porque conoce a todos los spells, aplicando el principio Expert
        this.AttackValue=this.GetSpellBookAttack(); 
        //Idem que con el ataque, pero para la defensa
        this.DefenseValue=this.GetSpellBookDefense();
        this.CureValue=this.GetSpellBookCure();
        NombreDefault();
        }
    public void NombreDefault(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Libro de hechizos";
        }
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
    public void PrintSpellBook(ICharacter wizard){

        Console.WriteLine($"{wizard.Name}'s SPELLBOOK SUMMARY");
        Console.WriteLine("Spells list:");
        byte contador=0;
        foreach(Spell spell in this.CharacterSpellBook){
            Console.WriteLine($"{spell} : N°{contador} | Attack : {spell.AttackValue} | Defense : {spell.DefenseValue} | Cure : {spell.CureValue}");
            contador++;
        }

    }
    public void DefaultName(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Libro de hechizos";
        }
    }
}
