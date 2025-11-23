using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class SoundSliderSciript : MonoBehaviour
{
    public AudioSource musica;
    public System.Collections.Generic.List<AudioSource> sfx;
    public Slider slide_volume;
    public Slider slide_sfx;

    public AudioMixer mixer;
    public Slider slider_narracao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        slide_sfx.value = PlayerPrefs.GetFloat("Audio1", 1f);
        slide_volume.value = PlayerPrefs.GetFloat("Audio2", 1f);
        slider_narracao.value = PlayerPrefs.GetFloat("AudioNarracao", 1f);
        AtualizarVolumes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void applyOptions()
    {
        PlayerPrefs.SetFloat("Audio1", slide_sfx.value);
        PlayerPrefs.SetFloat("Audio2", slide_volume.value);
        PlayerPrefs.SetFloat("AudioNarracao",slider_narracao.value);
        AtualizarVolumes();
    }

    private void AtualizarVolumes()
    {
        // SFX
        for (int i = 0; i < sfx.Count; i++)
            sfx[i].volume = slide_sfx.value;

        // Música
        musica.volume = slide_volume.value;

        // Narracao (Mixer)
        float narracaoValue = Mathf.Clamp(slider_narracao.value, 0.0001f, 1f);
        mixer.SetFloat("narracao", Mathf.Log10(narracaoValue) * 20);
    }
}
