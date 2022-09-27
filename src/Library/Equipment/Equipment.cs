using System;

namespace RPG
{
    public class Equipment : IEquipment
    {
        // Para armas y equipamiento en las manos.
        public IItem RightArm { get; set; }
        public IItem LeftArm { get; set; }

        // Para la armadura y protección.
        public Gear Armor { get; set; }

        public Inventory Inventory {get;set;}
        
        // * Constructor.
        public Equipment(Inventory inventory)
        {
            this.Inventory = inventory;
        }

        public void EquipRightArm(IItem weapon)
        {
            if (Inventory.CharacterWeaponry.Contains(weapon))
            {
                this.RightArm = weapon;
            }
            else
            {
                Console.WriteLine("No posees este arma en el inventario");
            }

        }

        public void EquipLeftArm(IItem weapon)
        {
            if (Inventory.CharacterWeaponry.Contains(weapon))
            {
                this.RightArm = weapon;
            }
            else
            {
                Console.WriteLine("No posees este arma en el inventario");
            }

        }

        public void EquipArmor(Gear armor)
        {
            if (Inventory.CharacterGear.Contains(armor))
            {
                this.Armor = armor;
            }
            else
            {
                Console.WriteLine("No posees este arma en el inventario");
            }
        }


        public void UnEquipRightArm()
        {
            this.RightArm = null;

        }
        public void UnEquipLeftArm()
        {
            this.LeftArm = null;

        }
        public void UnEquipArmor()
        {
            this.Armor = null;
        }

        public int GetAttackValue()
        {
            int attackValue = 0;
            
            if (this.LeftArm != null)
            {
                attackValue += this.LeftArm.AttackValue;
            }
            if (this.RightArm != null)
            {
                attackValue += this.RightArm.AttackValue;
            }
            return attackValue;
        }

        public int GetDefenseValue()
        {
            int defenseValue = 0;

            if (this.LeftArm != null)
            {
                defenseValue += this.LeftArm.DefenseValue;
            }
            if (this.RightArm != null)
            {
                defenseValue += this.RightArm.DefenseValue;
            }
            if (this.Armor != null)
            {
                defenseValue += this.Armor.DefenseValue;
            }

            return defenseValue;
        }

    }
}