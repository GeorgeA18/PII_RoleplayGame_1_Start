// * Interfaces para el equipamiento de los personajes tipos magicos.

// Se crea la interfaz IEquipment para establecer que ítems estan siendo utilizados activamente del inventario
// de cada personaje y que su ataque no esté definido por todo el valor de ataque que poseen (ítems activos + 
// ítems en el inventario). 
// Mediante el uso de la interfaz, podemos aplicar polimorfismo
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