using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card/Blackjack")]
public class CardData : ScriptableObject
{
    [SerializeField] int value;
    [SerializeField] bool isAce;
    [SerializeField] Material face;

    public int Value => isAce ? 11 : value;
    public bool IsAce => isAce;
    public Material Face => face;
}
