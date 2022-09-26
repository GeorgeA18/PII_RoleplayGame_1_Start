
namespace RPG;

public class DualItem : IItem{
    public string Name{get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue {get; set;}

    //Los ítems duales pueden tanto atacar como defender, por eso ambas variables pueden ser accedidas al momento de instanciarse
    public DualItem(string Name, int AttackValue, int DefenseValue){
        this.Name=Name.Trim();
        this.AttackValue=AttackValue;
        this.DefenseValue=DefenseValue;
        NombreDefault();
    }

    public void NombreDefault(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Dual Item";
        }
    }
}