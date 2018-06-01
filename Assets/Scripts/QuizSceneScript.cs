using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizSceneScript : MonoBehaviour
{

    public static int Score = 0;
    public static int QuestionNumber = 0;
    private string[] Questions = { "На чем вы собираетесь отправляться в командировку?",
        "Чем вы собираетесь заниматься в пути?", "В скольки звездочном отеле вы собираетесь проживать?",
        "Какую одежду вы наденете на первую встречу с руководстовом?"};
    private string[,] Answers =
    {
        {"Свой автомобиль", "Поезд", "Самолет", "Такси"},
        {"Спать", "Подготавливаться к работе", "Смотреть фильм", "Читать книгу"},
        {"5", "4", "3", "Не собираюсь проживать в отеле"},
        {"Никакую", "Оденусь по дресс-коду", "Повседневную одежду", "Деловой костюм"}
    };

    private Text QuestionText;
    private Text ButtonA;
    private Text ButtonB;
    private Text ButtonC;
    private Text ButtonD;

    private void Start()
    {
        QuestionText = GameObject.Find("Question").GetComponent<Text>();
        ButtonA = GameObject.Find("ButtonTextA").GetComponent<Text>();
        ButtonB = GameObject.Find("ButtonTextB").GetComponent<Text>();
        ButtonC = GameObject.Find("ButtonTextC").GetComponent<Text>();
        ButtonD = GameObject.Find("ButtonTextD").GetComponent<Text>();

        QuestionText.text = Questions[QuestionNumber];
        ButtonA.text = Answers[QuestionNumber, 0];
        ButtonB.text = Answers[QuestionNumber, 1];
        ButtonC.text = Answers[QuestionNumber, 2];
        ButtonD.text = Answers[QuestionNumber, 3];
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
            ButtonA.text = Answers[QuestionNumber, 0];
            ButtonB.text = Answers[QuestionNumber, 1];
            ButtonC.text = Answers[QuestionNumber, 2];
            ButtonD.text = Answers[QuestionNumber, 3];
        }
    }

    public void ClickA()
    {
        if (QuestionNumber == 0)
            Score += 900;
        if (QuestionNumber == 1)
            Score += 900;
        if (QuestionNumber == 2)
            Score += 500;
        if (QuestionNumber == 3)
            Score += 0;
        NextQuestion();
    }

    public void ClickB()
    {
        if (QuestionNumber == 0)
            Score += 1000;
        if (QuestionNumber == 1)
            Score += 1000;
        if (QuestionNumber == 2)
            Score += 1000;
        if (QuestionNumber == 3)
            Score += 1100;
        NextQuestion();
    }

    public void ClickC()
    {
        if (QuestionNumber == 0)
            Score += 500;
        if (QuestionNumber == 1)
            Score += 100;
        if (QuestionNumber == 2)
            Score += 1000;
        if (QuestionNumber == 3)
            Score += 900;
        NextQuestion();
    }

    public void ClickD()
    {
        if (QuestionNumber == 0)
            Score += 700;
        if (QuestionNumber == 1)
            Score += 500;
        if (QuestionNumber == 2)
            Score += 900;
        if (QuestionNumber == 3)
            Score += 1000;
        NextQuestion();
    }
}
