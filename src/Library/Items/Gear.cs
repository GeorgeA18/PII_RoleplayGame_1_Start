
namespace RPG;

public class Gear : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}

    // El ropaje no se usa para atacar ni para defender, son simplemente accesorios. Por eso sus valores son de 0
    public Gear(string Name){
        this.Name=Name.Trim();
        this.AttackValue=0;
        this.DefenseValue=0;
        DefaultName();
    }
    public void DefaultName(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Ropaje";
        }
    }
}