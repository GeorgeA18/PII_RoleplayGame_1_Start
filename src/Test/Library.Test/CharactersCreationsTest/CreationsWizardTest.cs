using NUnit.Framework;

using RPG;

namespace Test.Library
{
    // Todo: Estos tests se encarngan de verificar los atributos pasado como parametros en  la creación del personaje.
    public class WizardCreationTest
    {

        // TODO: Casos de prueba para el atributo Name
        [Test]
        public void ValidName()
        {
            const string nameValid = "harry";
            const string nameExpected = "harry";

            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard(nameValid, 100, harryEquipment, harrySpellBook, 25);

            Assert.That(nameExpected, Is.EqualTo(harry.Name));

            Assert.Pass("Paso la prueba 1 de nombre.");
        }

        [Test]
        public void invalidName()
        {
            const string nameWrong1 = "   ";
            const string nameWrong2 = "";
            const string nameExpected = "Sin Nombre";

            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard(nameWrong1, 100, harryEquipment, harrySpellBook, 25);

            Assert.That(nameExpected, Is.EqualTo(harry.Name));

            Wizard brian = new Wizard(nameWrong2, 100, harryEquipment, harrySpellBook, 40);
            Assert.That(nameExpected, Is.EqualTo(brian.Name));


            Assert.Pass("Pasó la prueba 2 de nombre.");
        }


        // TODO: Casos de Prueba para el atributo Health.
        // * Caso para el Health válido.
        [Test]
        public void ValidHealth()
        {
            const int health = 100;
            const int expected = 100;

            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("Harry", health, harryEquipment, harrySpellBook, 25);

            Assert.That(expected, Is.EqualTo(harry.Health));

            Assert.Pass("Pasó la prueba 1 de vida.");
        }

        // * Caso de prueba para el Health inválido.
        [Test]
        public void invalidHelath()
        {
            const int healthWrong1 = 0;
            const int healthWrong2 = 301;
            const int expected = 100;

            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("Harry", healthWrong1, harryEquipment, harrySpellBook, 25);

            Assert.That(expected, Is.EqualTo(harry.Health));

            Wizard brian = new Wizard("brian", healthWrong2, harryEquipment, harrySpellBook, 40);
            Assert.That(expected, Is.EqualTo(brian.Health));


            Assert.Pass("Pasó la prueba 2 de vida.");
        }


        // TODO: Casos de Prueba para el atributo DefaultCure.
        // * Caso para el DefaultCure válido.
        [Test]
        public void ValidCure()
        {
            const int cure = 40;
            const int expected = 40;

            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("Harry", 100, harryEquipment, harrySpellBook, cure);

            Assert.That(expected, Is.EqualTo(harry.DefaultCure));

            Assert.Pass("Pasó la prueba 1 de cura.");
        }

        // * Caso de prueba para el DefaultCure inválido.
        [Test]
        public void invalidCure()
        {
            const int cureWrong1 = 0;
            const int cureWrong2 = 61;
            const int expected = 50;

            Inventory harryInventory = new Inventory();
            Equipment harryEquipment = new Equipment(harryInventory);
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("Harry", 100, harryEquipment, harrySpellBook, cureWrong1);

            Assert.That(expected, Is.EqualTo(harry.DefaultCure));

            Wizard brian = new Wizard("brian", 100, harryEquipment, harrySpellBook, cureWrong2);
            Assert.That(expected, Is.EqualTo(brian.DefaultCure));


            Assert.Pass("Pasó la prueba 2 de cura.");
        }
    }
}