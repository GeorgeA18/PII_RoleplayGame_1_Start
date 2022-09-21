public class MagicItem : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}
    public int MagicPower{get; set;}

    public MagicItem(string Name, int AttackValue, int DefenseValue, bool Magic=true){
        
    }

}