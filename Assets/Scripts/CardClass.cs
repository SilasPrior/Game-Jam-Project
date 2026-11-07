using UnityEngine;


public class DeckCard
{
    public string Name { get; }
    public Texture Face { get; }
    public bool IsAce { get; }
    public int Value { get; }

    public DeckCard(string name, Texture face, int value, bool isAce = false)
    {
        Name = name;
        Face = face;
        IsAce = isAce;
        Value = isAce ? 11 : value;
    }
}
