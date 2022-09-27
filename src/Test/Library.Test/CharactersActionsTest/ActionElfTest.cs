using NUnit.Framework;

using RPG;

namespace Test.Library{
    public class ElfActionsTest
    {
        [Test]
        public void ValidActionAtack()
        {
            int Health = 100;
            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", Health, harryEquipment, harrySpellBook, 40);
            Inventory BartolomeoInventory = new Inventory();
            Equipment BartolomeoEquipment = new Equipment(BartolomeoInventory);
            Weapon spiritualDagger = new Weapon("Spiritual Dagger", 40);
            BartolomeoInventory.AddWeaponry(spiritualDagger);
            BartolomeoEquipment.EquipRightArm(spiritualDagger);
            Elf Bartolomeo = new  Elf("Bartolomeo", 100, BartolomeoEquipment, 40);

            Bartolomeo.Attack(harry);
            Assert.That(Health - spiritualDagger.AttackValue, Is.EqualTo(harry.Health));
        }

        [Test]
        public void ValidActionDead()
        {
            int dead=0;
            int Health = 20;
            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", Health, harryEquipment, harrySpellBook, 40);
            Inventory BartolomeoInventory = new Inventory();
            Equipment BartolomeoEquipment = new Equipment(BartolomeoInventory);
            Weapon spiritualDagger = new Weapon("Spiritual Dagger", 40);
            BartolomeoInventory.AddWeaponry(spiritualDagger);
            BartolomeoEquipment.EquipRightArm(spiritualDagger);
            Elf Bartolomeo = new  Elf("Bartolomeo", 100, BartolomeoEquipment, 40);

            
            Bartolomeo.Attack(harry);
            Assert.That(dead, Is.EqualTo(harry.Health));
        }
        [Test]
        public void ValidActionCure()
        {
            int cure=40;
            int Health=60;
            Inventory BartolomeoInventory = new Inventory();
            Equipment BartolomeoEquipment = new Equipment(BartolomeoInventory);
            Elf Bartolomeo = new  Elf("Bartolomeo", Health, BartolomeoEquipment, 40);
            
            Bartolomeo.Cure(Bartolomeo);
            Assert.That(cure+Health, Is.EqualTo(Bartolomeo.Health));
        }

        [Test]
        public void IncorrectActionCure()
        {
            int cure=40;
            int maxHealth=100;
            Inventory BartolomeoInventory = new Inventory();
            Equipment BartolomeoEquipment = new Equipment(BartolomeoInventory);
            Elf Bartolomeo = new  Elf("Bartolomeo", 100, BartolomeoEquipment, cure);
            
            Bartolomeo.Cure(Bartolomeo);
            Assert.That(Bartolomeo.Health, Is.EqualTo(maxHealth));
        }
    }
}