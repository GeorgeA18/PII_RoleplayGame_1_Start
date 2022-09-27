using NUnit.Framework;

using RPG;

namespace Test.Library
{
    // Todo: Estos tests se encarngan de verificar los atributos pasado como parametros en  la creación del personaje.
    public class WizardActionsTest
    {
        [Test]
        public void ValidActionAtack()
        {
            int Health = 100;
            
            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Weapon MagicStick = new Weapon("Magic Stick", 40);
            harryInventory.AddWeaponry(MagicStick);
            harryEquipment.EquipRightArm(MagicStick);
            Wizard harry = new Wizard("Harry", 100, harryEquipment, harrySpellBook, 25);

            Inventory BartolomeoInventory = new Inventory();
            Equipment BartolomeoEquipment = new Equipment(BartolomeoInventory);
            Elf Bartolomeo = new  Elf("Bartolomeo", Health, BartolomeoEquipment, 40);

            
            harry.Attack(Bartolomeo);
            Assert.That(Health - MagicStick.AttackValue, Is.EqualTo(Bartolomeo.Health));
        }

        [Test]
        public void ValidActionDead()
        {
            int dead=0;
            int Health = 20;
            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Weapon MagicStick = new Weapon("Magic Stick", 40);
            harryInventory.AddWeaponry(MagicStick);
            harryEquipment.EquipRightArm(MagicStick);
            Wizard harry = new Wizard("Harry", 100, harryEquipment, harrySpellBook, 25);


            Inventory BartolomeoInventory = new Inventory();
            Equipment BartolomeoEquipment = new Equipment(BartolomeoInventory);
            Elf Bartolomeo = new  Elf("Bartolomeo", Health, BartolomeoEquipment, 40);
            
            harry.Attack(Bartolomeo);
            Assert.That(dead, Is.EqualTo(Bartolomeo.Health));
        }
        [Test]
        public void ValidActionCure()
        {
            int cure=40;
            int Health=60;
            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("Harry", Health, harryEquipment, harrySpellBook, cure);
            
            harry.Cure(harry);
            Assert.That(cure+Health, Is.EqualTo(harry.Health));
        }

        [Test]
        public void IncorrectActionCure()
        {
            int cure=40;
            int maxHealth=100;
            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("Harry", 100, harryEquipment, harrySpellBook, cure);
            
            harry.Cure(harry);
            Assert.That(harry.Health, Is.EqualTo(maxHealth));
        }
    }
}