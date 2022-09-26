
namespace RPG;

public class Weapon : IItem{
    public string Name{get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}

    //Las armas puras solo atacan, por eso su valor de defensa es siempre 0 
    public Weapon(string Name, int AttackValue){
        this.Name=Name.Trim();
        this.AttackValue=AttackValue;
        this.DefenseValue=0;
        NombreDefault();
    }
    public void NombreDefault(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Arma";
        }
    }
}