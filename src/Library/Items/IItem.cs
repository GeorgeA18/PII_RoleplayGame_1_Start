public interface IItem{
    string Name {get; set;}
    int AttackValue {get; set;}
    int DefenseValue {get; set;}
    //Con el bool Magic podemos diferenciar los elementos magicos de los que no.
    //Al momento de utilizar un ítem, el juego deberá fijarse en este valor para dejar o no 
    // al personaje utilizar este ítem (dependiendo si es mago o no)
    bool Magic {get; set;}
}