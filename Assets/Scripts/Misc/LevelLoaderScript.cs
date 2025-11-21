using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public Animator transition;
    public float transition_time = 1.0f;
    public GameObject menu_principal;
    public void play()
    {
        LoadNextLevel();

    }

    public void LoadNextLevel()
    {
        menu_principal.SetActive(false);
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transition_time);

        SceneManager.LoadScene(levelIndex);
    }
}
