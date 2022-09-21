public interface ICharacter{
    string Name{get;set;}
    int Health{get;set;}
    Inventory Inventory {get; set;}
    int AttackValue();
    int DefenseValue();
    void Attack();
    void ReceiveAttack();
    void Cure();

}