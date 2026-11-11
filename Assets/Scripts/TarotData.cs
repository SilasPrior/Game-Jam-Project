using UnityEngine;

[CreateAssetMenu(fileName = "NewTarot", menuName = "Card/Tarot")]
public class TarotData : ScriptableObject
{
    [SerializeField] Material _face;
    [SerializeField] Texture _texture;
    [SerializeField] TarotCategory _useCategory;
    [SerializeField] bool _temperanceable;

    public Material Face => _face;
    public Texture Texture => _texture;
    public TarotCategory UseCategory => _useCategory;
    public bool Temperanceable => _temperanceable;
}
