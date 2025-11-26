using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore2 : MonoBehaviour
{
    [SerializeField] private Transform entryContainer;
    [SerializeField] private Transform entryTemplate;
    public float templateHeight;
    private List<HighScoreEntry> highScoreEntryList;
    private List<Transform> highscoreEntryTransformList;

    private Sprite vida_spr;
    public static HighScore2 Instance;

    private Highscores highscores;
    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantém o objeto entre cenas
        }


        entryTemplate.gameObject.SetActive(false);



        string jsonString = PlayerPrefs.GetString("highscoreTable2", "");

        Highscores highscores;

        if (string.IsNullOrEmpty(jsonString))
        {
            highscores = new Highscores();
            highscores.highscoreEntryList = new List<HighScoreEntry>();
        }
        else
        {
            highscores = JsonUtility.FromJson<Highscores>(jsonString);

            // Se a lista veio nula, inicializa
            if (highscores.highscoreEntryList == null)
                highscores.highscoreEntryList = new List<HighScoreEntry>();
        }
        highScoreEntryList = highscores.highscoreEntryList;

        highscoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highscoreEntry in highScoreEntryList)
        {
            CreateHighScoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }



    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void CreateHighScoreEntryTransform(HighScoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {

        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);


        string name = highscoreEntry.name;
        entryTransform.Find("TemplateNome").GetComponent<Text>().text = name;

        int score = highscoreEntry.acertos;
        
        entryTransform.Find("TemplatePontos").GetComponent<Text>().text = score.ToString();

        int vida = highscoreEntry.erros;
        
        entryTransform.Find("TemplateVidaTemporario").GetComponent<Text>().text = vida.ToString();

        string resultado = highscoreEntry.resultado;
        entryTransform.Find("TemplateResultado").GetComponent<Text>().text = resultado;

        transformList.Add(entryTransform);
    }

    public void AddHighScoreEntry(int score, string name, int vida, string resultado)
    {
        HighScoreEntry highscoreEntry = new HighScoreEntry { acertos = score, name = name, erros = vida, resultado = resultado };
        string jsonString = PlayerPrefs.GetString("highscoreTable2", "");
        Highscores highscores;
        if (string.IsNullOrEmpty(jsonString))
        {
            highscores = new Highscores();
            highscores.highscoreEntryList = new List<HighScoreEntry>();
        }
        else
        {
            highscores = JsonUtility.FromJson<Highscores>(jsonString);
            if (highscores.highscoreEntryList == null)
                highscores.highscoreEntryList = new List<HighScoreEntry>();
        }



        highscores.highscoreEntryList.Add(highscoreEntry);

        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable2", json);
        PlayerPrefs.Save();
    }

    private class Highscores
    {
        public List<HighScoreEntry> highscoreEntryList;
    }

    [System.Serializable]
    private class HighScoreEntry
    {
        public int acertos;
        public string name;
        public int erros;
        public string resultado;
    }

    public void apagarPontuacoes()
    {
        PlayerPrefs.SetString("highscoreTable2", "");

    }
}
