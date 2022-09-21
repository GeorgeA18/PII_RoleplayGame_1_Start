public class Dwarves : ICharacter{
    public string Name{get;set;}
    public Inventory Inventory {get; set;}
    public int Health{get;set;}
    public int AttackValue{get;set;}
    public int DefenseValue{get;set;}

    public Dwarves(string Name, Inventory Inventory, int Health, int AttackValue, int DefenseValue){
        this.Name=Name;
        this.Inventory=Inventory;
        this.AttackValue = AttackValue;
        this.DefenseValue = DefenseValue;
        this.Health = Health;
    }

    public void Attack(){

    }
    public void ReceiveAttack(){

    }
    public void Cure(){

    }
}