using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragDropSceneScript : MonoBehaviour
{

    private GameObject VariantA;
    private GameObject VariantB;
    private GameObject VariantC;
    private GameObject VariantD;

    private GameObject SlotA;
    private GameObject SlotB;
    private GameObject SlotC;
    private GameObject SlotD;

    private string[] Answers = { "Документы", "Семью", "Собаку", "Деньги" };

    private void Start()
    {
        SlotA = GameObject.Find("SlotA");
        SlotB = GameObject.Find("SlotB");
        SlotC = GameObject.Find("SlotC");
        SlotD = GameObject.Find("SlotD");

        VariantA = GameObject.Find("VariantA");
        VariantB = GameObject.Find("VariantB");
        VariantC = GameObject.Find("VariantC");
        VariantD = GameObject.Find("VariantD");

        VariantA.GetComponentInChildren<Text>().text = Answers[0];
        VariantB.GetComponentInChildren<Text>().text = Answers[1];
        VariantC.GetComponentInChildren<Text>().text = Answers[2];
        VariantD.GetComponentInChildren<Text>().text = Answers[3];
    }

    public void Finish()
    {
        if ((SlotA.transform.GetChild(0).gameObject == VariantA && SlotC.transform.GetChild(0).gameObject == VariantD) ||
            (SlotC.transform.GetChild(0).gameObject == VariantA && SlotA.transform.GetChild(0).gameObject == VariantD))
            QuizSceneScript.Score += 1000;

        if ((SlotB.transform.GetChild(0).gameObject == VariantB && SlotD.transform.GetChild(0).gameObject == VariantC) ||
             (SlotD.transform.GetChild(0).gameObject == VariantB && SlotB.transform.GetChild(0).gameObject == VariantC))
            QuizSceneScript.Score += 1000;

        SceneManager.LoadScene("FinishScene");
    }

}
