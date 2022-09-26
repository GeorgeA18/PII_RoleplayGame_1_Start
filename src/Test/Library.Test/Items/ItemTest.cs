using RPG;
using System;
using NUnit.Framework;

namespace Test.Library
{
    public class ItemTest
    {
        [Test]
        public void UntrimedName(){
            const string untrimedName = "  Daga  ";
            const string expectedName = "Daga";
            Weapon daga = new Weapon(untrimedName, 10, false);
            Assert.That(expectedName, Is.EqualTo(daga.Name));
        }

        [Test]
        public void ValidNameweapon(){
            const string untrimedName = "  ";
            const string expectedName = "Arma";
            Weapon daga = new Weapon(untrimedName, 10, false);
            Assert.That(expectedName, Is.EqualTo(daga.Name));
        }

        [Test]
        public void ValidNameProtection(){
            const string untrimedName = "  ";
            const string expectedName = "Protección";
            Protection prot = new Protection(untrimedName, 10, false);
            Assert.That(expectedName, Is.EqualTo(prot.Name));
        }

        [Test]
        public void ValidNameDualItem(){
            const string untrimedName = "  ";
            const string expectedName = "Dual Item";
            DualItem dual = new DualItem(untrimedName, 10, 10, false);
            Assert.That(expectedName, Is.EqualTo(dual.Name));
        }

        [Test]
        public void ValidNameSpellBook(){
            const string untrimedName = "  ";
            const string expectedName = "Libro de hechizos";
            SpellBook libro = new SpellBook(untrimedName);
            Assert.That(expectedName, Is.EqualTo(libro.Name));
        }

        [Test]
        public void ValidNameGear(){
            const string untrimedName = "  ";
            const string expectedName = "Ropaje";
            Gear gear = new Gear(untrimedName, false);
            Assert.That(expectedName, Is.EqualTo(gear.Name));
        }


    }    
}