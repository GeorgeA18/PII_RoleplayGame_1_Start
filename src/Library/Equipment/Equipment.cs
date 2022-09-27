

namespace RPG
{
    public class Equipment : IEquipment
    {
        // Para armas y equipamiento en las manos.
        public IItem RightArm { get; set; }
        public IItem LeftArm { get; set; }

        // Para la armadura y protección.
        public Protection Armor { get; set; }
        

    }
}