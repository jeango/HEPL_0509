using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public Renderer textureRenderer;
    public float scrollSpeed;
    public Vector2 scrollDirection;
    private Material textureMaterial;
    // Start is called before the first frame update
    void Start()
    {
        textureMaterial = textureRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        textureMaterial.mainTextureOffset += scrollDirection.normalized * (scrollSpeed * Time.deltaTime);
    }
}
