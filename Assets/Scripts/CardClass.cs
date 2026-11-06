using UnityEngine;

public class DeckCard
{
    string name;
    Texture face;
    int worth;

    DeckCard(string name, Texture face, int worth)
    {
        this.name = name;
        this.face = face;
        this.worth = worth;
    }
}
