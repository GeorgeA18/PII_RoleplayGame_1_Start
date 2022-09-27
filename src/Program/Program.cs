using System;

namespace RPG
{
    class Game
    {
        static void Main(string[] args)
        {

            //Instancias para cada personaje
            // * Creando a un Wizard.
            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("Harry", 100, harryEquipment, harrySpellBook, 25);

            Weapon MagicStick = new Weapon("Magic Stick", 40);
            harryInventory.AddWeaponry(MagicStick);
            harryEquipment.EquipRightArm(MagicStick);

            harry.SubmitCharacter();
        
                        // * Creando a un Dwarf.
                        Inventory gimliInventory= new Inventory();
                        Equipment gimliEquimpent = new Equipment(gimliInventory);
                        Protection roundedShield = new Protection("Rounded shield", 20);
                        Weapon battleAxe = new Weapon("Battle Axe", 30);
                        Dwarf gimli = new Dwarf("Gimli", 100, gimliEquimpent, 60);
                        gimliInventory.AddWeaponry(battleAxe);
                        gimliInventory.AddWeaponry(roundedShield);
                        gimliEquimpent.EquipLeftArm(roundedShield);
                        gimliEquimpent.EquipRightArm(battleAxe);
                        gimli.SubmitCharacter();


                        // * Creando a un Elf
                        Inventory BartolomeoInventory = new Inventory();
                        Equipment BartolomeoEquipment = new Equipment(BartolomeoInventory);
                        Elf Bartolomeo = new  Elf("Bartolomeo", 100, BartolomeoEquipment, 30);
                        Protection spiritualShield = new Protection("Spiritual shield", 10);
                        Weapon spiritualDagger = new Weapon("Spiritual Dagger", 40);
                        BartolomeoInventory.AddWeaponry(spiritualDagger);
                        BartolomeoInventory.AddWeaponry(spiritualShield);
                        Bartolomeo.SubmitCharacter();


                        // * Creando a un Dwarf
                        Inventory bolsonInventory = new Inventory();
                        Equipment bolsonEuipment= new Equipment(bolsonInventory);
                        Dwarf bolson = new Dwarf("Bolson", 100, bolsonEuipment, 60);
                        Weapon silverSword = new Weapon("silver Sword", 30);
                        Protection woodenShield = new Protection("Wooden shield", 10);
                        bolsonInventory.AddWeaponry(silverSword);
                        bolsonInventory.AddWeaponry(woodenShield);
                        bolsonEuipment.EquipRightArm(silverSword);
                        bolsonEuipment.EquipLeftArm(woodenShield);
                        bolson.SubmitCharacter();

            /*
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
