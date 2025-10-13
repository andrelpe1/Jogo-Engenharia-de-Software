using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainScript : MonoBehaviour
{
    public void Play_again()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
