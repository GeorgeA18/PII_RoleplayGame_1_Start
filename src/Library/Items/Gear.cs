public class Gear : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public bool Magic{get; set;}

    //El ropaje no se usa para atacar ni ara defender, son simpemente accesorios. Por eso sus valores son de 0
    public Gear(string Name, bool Magic){
        this.Name=Name.Trim();
        this.AttackValue=0;
        this.DefenseValue=0;
        this.Magic=Magic;
        NombreDefault();
    }

    public void NombreDefault(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Ropaje";
        }
    }
}