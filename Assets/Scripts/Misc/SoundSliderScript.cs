using UnityEngine;
using UnityEngine.UI;
public class SoundSliderSciript : MonoBehaviour
{
    public AudioSource musica;
    public AudioSource sfx;
    public Slider slide_volume;
    public Slider slide_sfx;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void applyOptions()
    {
        sfx.volume = slide_sfx.value;
        musica.volume = slide_volume.value;
    }
}
