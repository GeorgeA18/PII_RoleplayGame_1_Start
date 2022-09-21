public class DualItem : IItem{
    public string Name{get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue {get; set;}
    public bool Magic {get; set;}

    public DualItem(string Name, int AttackValue, int DefenseValue, bool Magic){
        this.Name=Name;
        this.AttackValue=AttackValue;
        this.DefenseValue=DefenseValue;
        this.Magic=Magic;
    }
}