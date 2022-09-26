// * Interfaces para el equipamiento de los personajes tipos magicos.

namespace RPG;

public interface IEquipment
{
    public ICharacter Character { get; set; }
    // Para armas y equipamiento en las manos.
    public IItem RightArm { get; set; }
    public IItem LeftArm { get; set; }

    // Para la armadura y protección.
    public Protection Armor { get; set; }

    void EquipRightArm(IItem weapon);
    void EquipLeftArm(IItem weapon);
    void EquipArmor(Protection armor);

}