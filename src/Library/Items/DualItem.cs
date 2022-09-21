public class DualItem : IItem{
    public string Name{get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue {get; set;}
    public bool Magic {get; set;}

    //Los ítems duales pueden tanto atacar como defender, por eso ambas variables pueden ser accedidas al momento de instanciarse
    public DualItem(string Name, int AttackValue, int DefenseValue, bool Magic){
        this.Name=Name;
        this.AttackValue=AttackValue;
        this.DefenseValue=DefenseValue;
        this.Magic=Magic;
    }
}