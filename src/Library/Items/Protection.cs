public class Protection : IItem{
    public string Name {get; set;}
    public int AttackValue{get; set;}
    public int DefenseValue{get; set;}
    //La protección solo sirve como defensa, no se usa para atacar, por eso su valor de ataque es 0
    public Protection(string Name, int DefenseValue){
        this.Name=Name.Trim();
        this.AttackValue=0;
        this.DefenseValue=DefenseValue;
        NombreDefault();
    }

    public void NombreDefault(){
        if(string.IsNullOrEmpty(this.Name)){
            this.Name="Protección";
        }
    }
}