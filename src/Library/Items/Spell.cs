
namespace RPG;

public class Spell{
    public string Name{get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    public int CureValue{get;set;}

    public Spell(string Name, int AttackValue, int DefenseValue, int CureValue){
        this.Name=Name.Trim();
        this.AttackValue=AttackValue;
        this.DefenseValue=DefenseValue;
        this.CureValue=CureValue;
    }
    public void DefaultName(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Spell";
        }
    
    }
    
}