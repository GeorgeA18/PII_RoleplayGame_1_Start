public class Elves : ICharacter{
    //Se tiene que poner que calcule el ataque/defensa, iterando en cada lista del inventario, para solo los ítems que no sean mágicos
    //Attack, Cure, ReceiveAttack todavía no tienen código

    public string Name{get;set;}
    public Inventory Inventory {get; set;}
    public int Health{get;set;}
    public int AttackValue(){
        int ataque=0;
        return ataque;
    }
    public int DefenseValue(){
        int defensa=0;
        return defensa;
    }

    public Elves(string Name, Inventory Inventory, int Health, int AttackValue, int DefenseValue){
        this.Name=Name;
        this.Inventory=Inventory;
        this.Health = Health;
    }
    public void Attack(){

    }
    public void ReceiveAttack(){

    }
    public void Cure(){

    }
}