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
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", Health, harryInventory, harrySpellBook, 40);
            Inventory BartolomeoInventory = new Inventory();
            Elf Bartolomeo = new  Elf("Bartolomeo", 100, BartolomeoInventory, 40);
            Weapon spiritualDagger = new Weapon("Spiritual Dagger", 40, false);
            Bartolomeo.Inventory.AddWeaponry(spiritualDagger);

            Bartolomeo.Attack(harry, spiritualDagger);
            Assert.That(Health - spiritualDagger.AttackValue, Is.EqualTo(harry.Health));
        }

        [Test]
        public void ValidActionDead()
        {
            int dead=0;
            int Health = 20;
            Inventory harryInventory = new Inventory();
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", Health, harryInventory, harrySpellBook, 40);
            Inventory BartolomeoInventory = new Inventory();
            Elf Bartolomeo = new  Elf("Bartolomeo", 100, BartolomeoInventory, 40);
            Weapon spiritualDagger = new Weapon("Spiritual Dagger", 40, false);
            Bartolomeo.Inventory.AddWeaponry(spiritualDagger);

            
            Bartolomeo.Attack(harry, spiritualDagger);
            Assert.That(dead, Is.EqualTo(harry.Health));
        }
        [Test]
        public void ValidActionCure()
        {
            int cure=40;
            int Health=60;
            Inventory BartolomeoInventory = new Inventory();
            Elf Bartolomeo = new  Elf("Bartolomeo", Health, BartolomeoInventory, 40);
            
            Bartolomeo.Cure(Bartolomeo);
            Assert.That(cure+Health, Is.EqualTo(Bartolomeo.Health));
        }

        [Test]
        public void IncorrectActionCure()
        {
            int cure=40;
            int maxHealth=100;
            Inventory BartolomeoInventory = new Inventory();
            Elf Bartolomeo = new  Elf("Bartolomeo", 100, BartolomeoInventory, cure);
            
            Bartolomeo.Cure(Bartolomeo);
            Assert.That(Bartolomeo.Health, Is.EqualTo(maxHealth));
        }
    }
}