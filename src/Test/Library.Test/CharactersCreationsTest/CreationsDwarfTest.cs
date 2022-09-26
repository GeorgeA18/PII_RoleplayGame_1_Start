using NUnit.Framework;

using RPG;

namespace Test.Library
{
    // Todo: Estos tests se encarngan de verificar los atributos pasado como parametros en  la creación del personaje.
    public class DwarfCreationTest
    {

        // TODO: Casos de prueba para el atributo Name
        [Test]
        public void ValidName()
        {
            const string nameValid = "harry";
            const string nameExpected = "harry";

            Inventory harryInventory = new Inventory();
            Dwarf harry = new Dwarf(nameValid, 100, harryInventory, 40);

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
             
            Dwarf harry = new Dwarf(nameWrong1, 100, harryInventory, 40);

            Assert.That(nameExpected, Is.EqualTo(harry.Name));

            Dwarf brian = new Dwarf(nameWrong2, 100, harryInventory, 40);
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
             
            Dwarf harry = new Dwarf("harry", health, harryInventory, 40);

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
             
            Dwarf harry = new Dwarf("harry", healthWrong1, harryInventory, 40);

            Assert.That(expected, Is.EqualTo(harry.Health));

            Dwarf brian = new Dwarf("brian", healthWrong2, harryInventory, 40);
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
             
            Dwarf harry = new Dwarf("harry", 100, harryInventory, cure);

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
             
            Dwarf harry = new Dwarf("harry", 100, harryInventory, cureWrong1);

            Assert.That(expected, Is.EqualTo(harry.DefaultCure));

            Dwarf brian = new Dwarf("brian", 100, harryInventory, cureWrong2);
            Assert.That(expected, Is.EqualTo(brian.DefaultCure));


            Assert.Pass("Pasó la prueba 2 de cura.");
        }
    }
}