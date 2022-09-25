using System;

namespace RPG
{
    class Game
    {
        static void Main(string[] args)
        {
            
            //Instancias para cada personaje
            // * Creando a un Wizard
            Inventory harryInventory = new Inventory();
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("", 200, harryInventory, harrySpellBook,40);

            harry.SubmitCharacter();
/*
            // * Creando a un Dwarf
            Inventory gernisInventory = new Inventory();
            Dwarf gernis = new Dwarf("Gernis", 100, gernisInventory, 60);

            // * Creando a un Elf
            Inventory gimbelInventory = new Inventory();
            Elf gimbel = new Elf("Gimbel", 100, gimbelInventory, 40);

            

            //Instancias para cada item
            Gear robe = new Gear("Robe", false);
            Gear gown = new Gear("Gown", false);
            Gear wristlet = new Gear("Wristlet", false);
            
            Protection armor = new Protection("Armor", 40, false);
            Protection copperShield = new Protection("Copper Shield", 10, false);
            Protection silverShield = new Protection("Silver Shield", 20, false);
            Protection helmet = new Protection("Helmet", 10, false);
            Protection gauntlet = new Protection("Gauntlet", 10, false);

            Weapon sword = new Weapon("Sword", 10, false);
            Weapon axe = new Weapon("Axe", 10, false);
            Weapon spear = new Weapon("Spear", 10, false);
            Weapon dagger = new Weapon("Dagger", 10, false);
            Weapon crossbow = new Weapon("Crossbow", 20, false);
            Weapon magicSword = new Weapon("Magic Sword", 20, true);

            DualItem spikedShield = new DualItem("Spiked Shield", 10, 20, false);
            DualItem wand = new DualItem("Wand", 20, 20, true);
            DualItem scepter = new DualItem("Scepter", 20, 20, true);
*/
        }
    }
}
