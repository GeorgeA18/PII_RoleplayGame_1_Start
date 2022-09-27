using System;

namespace RPG;

public class ValidationCharacter : IValidationCharacters
{
    // Aquí se guarda el personaje a validar.
    public ICharacter Character { get; set; }

    // Constructor
    public ValidationCharacter(ICharacter character)
    {
        this.Character = character;
    }
    // Este método controla a los demas.
    public void ParameterReview()
    {
        this.NameReview(this.Character.Name);
        this.HealthReview(this.Character.Health);
        this.DefaultCureReview(this.Character.DefaultCure);
    }

    // Verifica que el nombre no esté vacío o sea inválido.
    public void NameReview(string name)  
    {
        
        if (string.IsNullOrEmpty(name))
        {
            this.Character.Name = "Sin Nombre";
        }
    }

    // Revisa si el valor del rango está dentro de los límites (1-->100).
    public void HealthReview(int health)
    {
        if (health <= 0 || health > 100)
        {
            this.Character.Health = 100;
        }
    }
    // Revisa si el valor del rango está dentro de los límites (1-->100).
    public void DefaultCureReview(int cureValue)
    {
        if (cureValue < 1 || cureValue > 100)
        {
            this.Character.DefaultCure = 50;
        }
    }


}