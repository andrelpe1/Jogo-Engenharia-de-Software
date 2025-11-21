using UnityEngine;
using UnityEngine.UI;

public class ParallaxUI : MonoBehaviour
{
    public float speed = 0f;

    private RawImage raw;

    void Start()
    {
        raw = GetComponent<RawImage>();
    }

    void Update()
    {
        if (raw != null)
        {
            // desloca a textura via uvRect
            Rect r = raw.uvRect;
            r.x += speed * Time.deltaTime;
            raw.uvRect = r;
        }
    }
}
