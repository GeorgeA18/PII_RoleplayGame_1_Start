public class Protection : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}

    //La protección solo sirve como defensa, no se usa para atacar, por eso su valor de ataque es 0
    public Protection(string Name, int DefenseValue, bool Magic){
        this.Name=Name;
        this.AttackValue=0;
        this.DefenseValue=DefenseValue;
        this.Magic=Magic;
    }
}