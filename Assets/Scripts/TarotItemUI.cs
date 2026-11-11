using UnityEngine;
using UnityEngine.UI;

public class TarotItemUI : MonoBehaviour
{
    public ITarotCard Card { get; set; }

    private RawImage _cardImage;
    private Button _cardButton;
    public void Initialize(ITarotCard card)
    {
        Card = card;
    }

    void Awake()
    {
        _cardImage.GetComponent<RawImage>();
        _cardButton.GetComponent<Button>();        
    }
    private void Start()
    {
        _cardImage.texture = Card.Data.Texture;
        _cardButton.onClick.RemoveAllListeners();
    }
}
