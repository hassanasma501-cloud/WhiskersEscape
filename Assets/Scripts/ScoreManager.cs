using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    private int score = 0;

    void Start()
    {
        textScore.text = "Fromage : 0";
    }

    public void AjouterPoint()
    {
        score++;
        textScore.text = "Fromage : " + score;
    }
}
