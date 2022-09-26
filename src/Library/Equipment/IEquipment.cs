// * Interfaces para el equipamiento de los personajes tipos magicos.

namespace RPG;

public interface IEquipment
{
    ICharacter character { get; set; }
    // Para armas y equipamiento en las manos.
    IItem rightArm { get; set; }
    IItem LeftArm { get; set; }

    // Para la armadura y protección.
    IItem armor { get; set; }

    void reghtArmEquip();

}