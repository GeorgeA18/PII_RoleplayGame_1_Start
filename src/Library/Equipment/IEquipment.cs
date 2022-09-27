// * Interfaces para el equipamiento de los personajes tipos magicos.

namespace RPG;

public interface IEquipment
{
    // Para armas y equipamiento en las manos.
    public IItem RightArm { get; set; }
    public IItem LeftArm { get; set; }

    // Para la armadura y protección.
    public Gear Armor { get; set; }

    public Inventory Inventory {get;set;}

    void EquipRightArm(IItem weapon);
    void EquipLeftArm(IItem weapon);
    void EquipArmor(Gear armor);

    void UnEquipRightArm();
    public void UnEquipLeftArm();
    public void UnEquipArmor();

    public int GetAttackValue();
    public int GetDefenseValue();
}