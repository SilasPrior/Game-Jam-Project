using UnityEngine;

public class CardObject : MonoBehaviour
{
    public Transform animationRoot;
    public GameObject animation;
    public GameObject model;

    public CardData cardData { get; set; }

    private bool isFaceUp = false;

    private Hand hand;

    private Animator animator;
    private Renderer renderer;

    private Transform cardTransform;

    public bool IsFaceUp
    {
        get => isFaceUp;
        set
        {
            if (isFaceUp == value) return;

            isFaceUp = value;

            flipCard();

        }
    }

    public void Awake()
    {
        animator = animation.GetComponent<Animator>();
        renderer = GetComponentInChildren<Renderer>();
        cardTransform = GetComponent<Transform>();
    }

    public void Initialize(CardData data, Hand cardHolder, bool faceUp)
    {
        cardData = data;
        hand = cardHolder;

        isFaceUp = faceUp;

        Material[] materials = renderer.materials;
        materials[1] = data.Face;
        renderer.materials = materials;

        model.transform.localRotation = Quaternion.Euler(IsFaceUp ? 0f : 180f, 0f, 0f);
        cardTransform.transform.localPosition = hand.Position;

    }

    private void flipCard()
    {
        animator.SetTrigger("Flip");
    }
}
