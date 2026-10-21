namespace Week6;

class Program
{
    static void Main(string[] args)
    {
        pupil pupil = new pupil();
        pupil.Character = "Thor";
        pupil.Ability = "Lightning";
        pupil.Weapon = "Mjolnir";
        Console.WriteLine("Character Name: " + pupil.Character);
        Console.WriteLine($"{pupil.Character}'s ability is: {pupil.Ability}");
        Console.WriteLine($"{pupil.Character}'s weapon is: {pupil.Weapon}");


        /*Console.WriteLine("Input the characters name: ");
        string character_name = Console.ReadLine();

        Console.WriteLine($"Input the {character_name}'s attack potential (1-10): ");
        string attack_potential = Console.ReadLine();

        Console.WriteLine($"Input the {character_name}'s defence potential (1-10): ");
        string defence_potential = Console.ReadLine();

        Console.WriteLine($"Input the {character_name}'s stamina points (1-10): ");
        string character_stamina = Console.ReadLine();

        Console.WriteLine($"Input the {character_name}'s health points (1-10): ");
        string character_health = Console.ReadLine();

        Console.WriteLine($"Input the {character_name}'s strength points (1-10): ");
        string character_strength = Console.ReadLine();

        Console.WriteLine($"The character is called {character_name} and he has the attack points of {attack_potential}, defence points of {defence_potential}, has the stanima of {character_stamina}, health points of {character_health} and finaly the characters strength count is {character_strength}");
        */

    }
}