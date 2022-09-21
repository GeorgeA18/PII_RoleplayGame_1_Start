public class Weapon : IItem{
    public string Name{get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}

    //Las armas puras solo atacan, por eso su valor de defensa es siempre 0 
    public Weapon(string Name, int AttackValue, bool Magic){
        this.Name=Name;
        this.AttackValue=AttackValue;
        this.DefenseValue=0;
        this.Magic=Magic;
    }
}