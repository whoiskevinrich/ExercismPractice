using System;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private readonly int _mask;

    public Allergies(int mask)
    {
        _mask = mask % 128;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return false;
    }

    public Allergen[] List()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    private int Weight(Allergen allergen)
    {
        return ((int) allergen)^2;
    }
}