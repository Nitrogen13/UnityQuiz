using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinishSceneScript : MonoBehaviour {

    private Text ScoreText;

    void Start () {
        ScoreText = GameObject.Find("Score").GetComponent<Text>();
        ScoreText.text = "Ваш счет: " + QuizSceneScript.Score;
    }

    public void StartAgain()
    {
        QuizSceneScript.QuestionNumber = 0;
        QuizSceneScript.Score = 0;
        SceneManager.LoadScene("QuizScene");
    }
}
