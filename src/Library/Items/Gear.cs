public class Gear : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}

    public Gear(string Name, int DefenseValue, bool Magic){
        this.Name=Name;
        this.AttackValue=0;
        this.DefenseValue=DefenseValue;
        this.Magic=Magic;
    }
}