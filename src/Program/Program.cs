﻿using System;

namespace RPG
{
    class Game
    {
        static void Main(string[] args)
        {
            //Instancias para cada personaje
            //Falta completar el funcionamiento de inventory
<<<<<<< HEAD
            Wizard harry = new Wizard("Harry", 100);
=======

            Inventory inventarioHarry = new Inventory();

            Wizard harry = new Wizard("Harry",inventarioHarry,100, 30, 20);
            harry.Health = 100;
>>>>>>> 4a5e9d5f69ea1e3e0ef95b8c0cb9885ee0c5b740

            Dwarf gernis = new Dwarf("Gernis", 100);

            Elf gimbel = new Elf("Gimbel", 100);

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

        }
    }
}
