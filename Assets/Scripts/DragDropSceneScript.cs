using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragDropSceneScript : MonoBehaviour
{

    private GameObject variantA;
    private GameObject variantB;
    private GameObject variantC;
    private GameObject variantD;

    private GameObject slotA;
    private GameObject slotB;
    private GameObject slotC;
    private GameObject slotD;

    private readonly string[] answers = { "Документы", "Семью", "Собаку", "Деньги" };

    private void Start()
    {
        slotA = GameObject.Find("SlotA");
        slotB = GameObject.Find("SlotB");
        slotC = GameObject.Find("SlotC");
        slotD = GameObject.Find("SlotD");

        variantA = GameObject.Find("VariantA");
        variantB = GameObject.Find("VariantB");
        variantC = GameObject.Find("VariantC");
        variantD = GameObject.Find("VariantD");

        variantA.GetComponentInChildren<Text>().text = answers[0];
        variantB.GetComponentInChildren<Text>().text = answers[1];
        variantC.GetComponentInChildren<Text>().text = answers[2];
        variantD.GetComponentInChildren<Text>().text = answers[3];
    }

    public void Finish()
    {
        if ((slotA.transform.GetChild(0).gameObject == variantA && slotC.transform.GetChild(0).gameObject == variantD) ||
            (slotC.transform.GetChild(0).gameObject == variantA && slotA.transform.GetChild(0).gameObject == variantD))
            QuizSceneScript.score[4] += 1000; 

        if ((slotB.transform.GetChild(0).gameObject == variantB && slotD.transform.GetChild(0).gameObject == variantC) ||
             (slotD.transform.GetChild(0).gameObject == variantB && slotB.transform.GetChild(0).gameObject == variantC))
            QuizSceneScript.score[4] += 1000;

        SceneManager.LoadScene("FinishScene");
    }

}
