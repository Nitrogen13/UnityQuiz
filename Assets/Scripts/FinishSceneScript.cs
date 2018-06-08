using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinishSceneScript : MonoBehaviour {

    private Text scoreText;

    void Start () {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = "Ваши результаты: \n"
            + "1) " + QuizSceneScript.score[0] + "/1000\n" 
            + "2) " + QuizSceneScript.score[1] + "/1000\n"
            + "3) " + QuizSceneScript.score[2] + "/1000\n"
            + "4) " + QuizSceneScript.score[3] + "/1000\n"
            + "5) " + QuizSceneScript.score[4] + "/2000\n";

    }

    public void StartAgain()
    {
        QuizSceneScript.questionNumber = 0;
        QuizSceneScript.score = new int[5];
        SceneManager.LoadScene("QuizScene");
    }
}
