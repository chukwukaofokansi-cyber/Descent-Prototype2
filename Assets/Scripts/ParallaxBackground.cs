using UnityEngine;

[System.Serializable]
public class BackgroundElement
{
    public SpriteRenderer backgroundSprite;
    [Range(0,1)] public float scrollSpeed;
    [HideInInspector] public Material spriteMaterial;
}
public class ParallaxBackground : MonoBehaviour
{
   private const float SCROLL_MULT = 0.01f;
    [SerializeField] private BackgroundElement[] backgroundElement;

    private void Start()
    {
        foreach (BackgroundElement element in backgroundElement)
        {
            element.backgroundSprite.material = element.backgroundSprite.material;
        }
    }

    private void Update()
    {
        foreach (BackgroundElement element in backgroundElement)
        {
           element.spriteMaterial.mainTextureOffset += new Vector2(transform.position.x * element.scrollSpeed * SCROLL_MULT * Time.deltaTime, 0);
        }
    }

}
