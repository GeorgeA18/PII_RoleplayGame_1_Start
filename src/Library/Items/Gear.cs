public class Gear : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}

    //El equipamiento solo sirve como defensa pasiva, no se usa para atacar, por eso su valor de ataque es 0
    public Gear(string Name, int DefenseValue, bool Magic){
        this.Name=Name;
        this.AttackValue=0;
        this.DefenseValue=DefenseValue;
        this.Magic=Magic;
    }
}