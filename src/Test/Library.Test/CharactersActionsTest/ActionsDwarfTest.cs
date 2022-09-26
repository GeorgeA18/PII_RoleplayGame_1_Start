using NUnit.Framework;

using RPG;

namespace Test.Library
{
    // Todo: Estos tests se encarngan de verificar los atributos pasado como parametros en  la creación del personaje.
    public class DwarfActionsTest
    {
        [Test]
        public void ValidActionAtack()
        {
            int Health = 100;
            Inventory BartolomeoInventory = new Inventory();
            Elf Bartolomeo = new  Elf("Bartolomeo", Health, BartolomeoInventory, 40);
            Inventory gimliInventory= new Inventory();
            Dwarf gimli = new Dwarf("Gimli", 100, gimliInventory, 60);
            Weapon battleAxe = new Weapon("Battle Axe", 30, false);
            gimli.Inventory.AddWeaponry(battleAxe);

            gimli.Attack(Bartolomeo, battleAxe);
            Assert.That(Health - battleAxe.AttackValue, Is.EqualTo(Bartolomeo.Health));
        }

        [Test]
        public void ValidActionDead()
        {
            int dead=0;
            int Health = 20;
            Inventory BartolomeoInventory = new Inventory();
            Elf Bartolomeo = new  Elf("Bartolomeo", Health, BartolomeoInventory, 40);
            Inventory gimliInventory= new Inventory();
            Dwarf gimli = new Dwarf("Gimli", 100, gimliInventory, 60);
            Weapon battleAxe = new Weapon("Battle Axe", 30, false);
            gimli.Inventory.AddWeaponry(battleAxe);
            
            gimli.Attack(Bartolomeo, battleAxe);
            Assert.That(dead, Is.EqualTo(Bartolomeo.Health));
        }
        [Test]
        public void ValidActionCure()
        {
            int cure=40;
            int Health=60;
            Inventory gimliInventory= new Inventory();
            Dwarf gimli = new Dwarf("Gimli", Health, gimliInventory, cure);
            
            gimli.Cure(gimli);
            Assert.That(cure+Health, Is.EqualTo(gimli.Health));
        }

        [Test]
        public void IncorrectActionCure()
        {
            int cure=40;
            int maxHealth=100;
            Inventory gimliInventory= new Inventory();
            Dwarf gimli = new Dwarf("Gimli", 100, gimliInventory, cure);
            
            gimli.Cure(gimli);
            Assert.That(gimli.Health, Is.EqualTo(maxHealth));
        }
    }
}