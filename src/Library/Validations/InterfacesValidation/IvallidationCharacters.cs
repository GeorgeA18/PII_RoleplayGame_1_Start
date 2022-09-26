

namespace RPG;

public interface IValidationCharacters
{
    ICharacter Character{get;set;}
    void ParameterReview();
    void NameReview(string name);
    void HealthReview(int health);
    void DefaultCureReview(int cureValue);

}