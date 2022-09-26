using NUnit.Framework;

using RPG;

namespace Test.Library
{
    // Todo: Estos tests se encarngan de verificar los atributos pasado como parametros en  la creación del personaje.
    public class WizardActionsfTest
    {

        // TODO: Casos de prueba para el atributo Name
        [Test]
        public void ValidName()
        {
            const string nameValid = "harry";
            const string nameExpected = "harry";

            Inventory harryInventory = new Inventory();
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard(nameValid, 100, harryInventory, harrySpellBook, 40);

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
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard(nameWrong1, 100, harryInventory, harrySpellBook, 40);

            Assert.That(nameExpected, Is.EqualTo(harry.Name));

            Wizard brian = new Wizard(nameWrong2, 100, harryInventory, harrySpellBook, 40);
            Assert.That(nameExpected, Is.EqualTo(brian.Name));


            Assert.Pass("Pasó la prueba 2 de nombre.");
        }


        // TODO: Casos de Prueba para el atributo Health.
        // * Caso para el Health valido.
        [Test]
        public void ValidHealth()
        {
            const int health = 200;
            const int expected = 200;

            Inventory harryInventory = new Inventory();
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", health, harryInventory, harrySpellBook, 40);

            Assert.That(expected, Is.EqualTo(harry.Health));

            Assert.Pass("Pasó la prueba 1 de vida.");
        }

        // * Caso de prueba para el Health invalido.
        [Test]
        public void invalidHelath()
        {
            const int healthWrong1 = 0;
            const int healthWrong2 = 301;
            const int expected = 100;

            Inventory harryInventory = new Inventory();
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", healthWrong1, harryInventory, harrySpellBook, 40);

            Assert.That(expected, Is.EqualTo(harry.Health));

            Wizard brian = new Wizard("brian", healthWrong2, harryInventory, harrySpellBook, 40);
            Assert.That(expected, Is.EqualTo(brian.Health));


            Assert.Pass("Pasó la prueba 2 de vida.");
        }


        // TODO: Casos de Prueba para el atributo DefualtCure.
        // * Caso para el DefaultCure valido.
        [Test]
        public void ValidCure()
        {
            const int cure = 40;
            const int expected = 40;

            Inventory harryInventory = new Inventory();
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", 200, harryInventory, harrySpellBook, cure);

            Assert.That(expected, Is.EqualTo(harry.DefaultCure));

            Assert.Pass("Pasó la prueba 1 de cura.");
        }

        // * Caso de prueba para el DefaultCure invalido.
        [Test]
        public void invalidCure()
        {
            const int cureWrong1 = 0;
            const int cureWrong2 = 61;
            const int expected = 20;

            Inventory harryInventory = new Inventory();
            SpellBook harrySpellBook = new SpellBook("Harry's Spellbook");
            Wizard harry = new Wizard("harry", 200, harryInventory, harrySpellBook, cureWrong1);

            Assert.That(expected, Is.EqualTo(harry.DefaultCure));

            Wizard brian = new Wizard("brian", 200, harryInventory, harrySpellBook, cureWrong2);
            Assert.That(expected, Is.EqualTo(brian.DefaultCure));


            Assert.Pass("Pasó la prueba 2 de cura.");
        }
    }
}