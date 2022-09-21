public interface ICharacter{
    string Name{get;set;}
    int Health{get;set;}
    int AttackValue{get;set;}
    int DefenseValue{get;set;}
    void Attack();
    void ReceiveAttack();
    void Cure();

}