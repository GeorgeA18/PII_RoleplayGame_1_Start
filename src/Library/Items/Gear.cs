public class Gear : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}

    //El ropaje no se usa para atacar ni ara defender, son simpemente accesorios. Por eso sus valores son de 0
    public Gear(string Name){
        this.Name=Name.Trim();
        this.AttackValue=0;
        this.DefenseValue=0;
        NombreDefault();
    }

    public void NombreDefault(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Ropaje";
        }
    }
}