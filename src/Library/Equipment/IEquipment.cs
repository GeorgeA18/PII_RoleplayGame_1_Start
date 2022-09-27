// * Interfaces para el equipamiento de los personajes tipos magicos.

namespace RPG;

public interface IEquipment
{
    // Para armas y equipamiento en las manos.
    public IItem RightArm { get; set; }
    public IItem LeftArm { get; set; }

    // Para la armadura y protección.
    public Protection Armor { get; set; }

}