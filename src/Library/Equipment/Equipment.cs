

namespace RPG
{
    public class Equipment : IEquipment
    {
        public ICharacter Character { get; set; }
        // Para armas y equipamiento en las manos.
        public IItem RightArm { get; set; }
        public IItem LeftArm { get; set; }

        // Para la armadura y protección.
        public Protection Armor { get; set; }


        // * Constructor.
        public Equipment(ICharacter character)
        {
            this.Character = character;
        }

        // * Meotodos para equipar armas y armadura.
        public void EquipRightArm(IItem weapon)
        {
            this.RightArm = weapon;
        }
        public void EquipLeftArm(IItem weapon)
        {

            this.LeftArm = weapon;
        }
        public void EquipArmor(Protection armor)
        {
            this.Armor = armor;
        }

    }
}