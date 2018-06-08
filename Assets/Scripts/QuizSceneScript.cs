using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizSceneScript : MonoBehaviour
{

    public static int[] score = new int[5];
    public static int questionNumber = 0;
    private readonly string[] questions =
    {   "На чем вы собираетесь отправляться в командировку?",
        "Чем вы собираетесь заниматься в пути?",
        "В скольки звездочном отеле вы собираетесь проживать?",
        "Какую одежду вы наденете на первую встречу с руководстовом?"
    };
    private readonly string[,] answers =
    {
        {"Свой автомобиль", "Поезд", "Самолет", "Такси"},
        {"Спать", "Подготавливаться к работе", "Смотреть фильм", "Читать книгу"},
        {"5", "4", "3", "Не собираюсь проживать в отеле"},
        {"Никакую", "Оденусь по дресс-коду", "Повседневную одежду", "Деловой костюм"}
    };

    private readonly int[,] scores =
    {
        {900, 1000, 500, 700},
        {900, 1000, 100, 500},
        {500, 1000, 1000, 900},
        {0, 1100, 900, 1000}
    };

    private Text questionText;
    private GameObject buttonA;
    private GameObject buttonB;
    private GameObject buttonC;
    private GameObject buttonD;

    private void Start()
    {
        questionText = GameObject.Find("Question").GetComponent<Text>();
        buttonA = GameObject.Find("ButtonTextA");
        buttonB = GameObject.Find("ButtonTextB");
        buttonC = GameObject.Find("ButtonTextC");
        buttonD = GameObject.Find("ButtonTextD");

        questionText.text = questions[questionNumber];
        buttonA.GetComponent<Text>().text = answers[questionNumber, 0];
        buttonB.GetComponent<Text>().text = answers[questionNumber, 1];
        buttonC.GetComponent<Text>().text = answers[questionNumber, 2];
        buttonD.GetComponent<Text>().text = answers[questionNumber, 3];
    }

    private void NextQuestion()
    {
        if (questionNumber == 3)
        {
            SceneManager.LoadScene("DragAndDropScene");
        }
        else
        {
            questionText.text = questions[++questionNumber];
            buttonA.GetComponent<Text>().text = answers[questionNumber, 0];
            buttonB.GetComponent<Text>().text = answers[questionNumber, 1];
            buttonC.GetComponent<Text>().text = answers[questionNumber, 2];
            buttonD.GetComponent<Text>().text = answers[questionNumber, 3];
        }
    }

    public void ClickA()
    {
        score[questionNumber] = scores[questionNumber, 0];
        NextQuestion();
    }

    public void ClickB()
    {
        score[questionNumber] = scores[questionNumber, 1];
        NextQuestion();
    }

    public void ClickC()
    {
        score[questionNumber] = scores[questionNumber, 2];
        NextQuestion();
    }

    public void ClickD()
    {
        score[questionNumber] = scores[questionNumber, 3];
        NextQuestion();
    }
}
