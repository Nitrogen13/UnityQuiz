using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizSceneScript : MonoBehaviour
{

    public static int Score = 0;
    public static int QuestionNumber = 0;
    private readonly string[] Questions =
    {   "На чем вы собираетесь отправляться в командировку?",
        "Чем вы собираетесь заниматься в пути?",
        "В скольки звездочном отеле вы собираетесь проживать?",
        "Какую одежду вы наденете на первую встречу с руководстовом?"
    };
    private readonly string[,] Answers =
    {
        {"Свой автомобиль", "Поезд", "Самолет", "Такси"},
        {"Спать", "Подготавливаться к работе", "Смотреть фильм", "Читать книгу"},
        {"5", "4", "3", "Не собираюсь проживать в отеле"},
        {"Никакую", "Оденусь по дресс-коду", "Повседневную одежду", "Деловой костюм"}
    };

    private readonly int[,] Scores =
    {
        {900, 1000, 500, 700},
        {900, 1000, 100, 500},
        {500, 1000, 1000, 900},
        {0, 1100, 900, 1000}
    };

    private Text QuestionText;
    private GameObject ButtonA;
    private GameObject ButtonB;
    private GameObject ButtonC;
    private GameObject ButtonD;

    private void Start()
    {
        QuestionText = GameObject.Find("Question").GetComponent<Text>();
        ButtonA = GameObject.Find("ButtonTextA");
        ButtonB = GameObject.Find("ButtonTextB");
        ButtonC = GameObject.Find("ButtonTextC");
        ButtonD = GameObject.Find("ButtonTextD");

        QuestionText.text = Questions[QuestionNumber];
        ButtonA.GetComponent<Text>().text = Answers[QuestionNumber, 0];
        ButtonB.GetComponent<Text>().text = Answers[QuestionNumber, 1];
        ButtonC.GetComponent<Text>().text = Answers[QuestionNumber, 2];
        ButtonD.GetComponent<Text>().text = Answers[QuestionNumber, 3];
    }

    private void NextQuestion()
    {
        if (QuestionNumber == 3)
        {
            SceneManager.LoadScene("DragAndDropScene");
        }
        else
        {
            QuestionText.text = Questions[++QuestionNumber];
            ButtonA.GetComponent<Text>().text = Answers[QuestionNumber, 0];
            ButtonB.GetComponent<Text>().text = Answers[QuestionNumber, 1];
            ButtonC.GetComponent<Text>().text = Answers[QuestionNumber, 2];
            ButtonD.GetComponent<Text>().text = Answers[QuestionNumber, 3];
        }
    }

    public void ClickA()
    {
        Score += Scores[QuestionNumber, 0];
        NextQuestion();
    }

    public void ClickB()
    {
        Score += Scores[QuestionNumber, 1];
        NextQuestion();
    }

    public void ClickC()
    {
        Score += Scores[QuestionNumber, 2];
        NextQuestion();
    }

    public void ClickD()
    {
        Score += Scores[QuestionNumber, 3];
        NextQuestion();
    }
}
