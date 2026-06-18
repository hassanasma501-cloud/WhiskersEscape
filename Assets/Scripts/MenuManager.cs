using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject panelStart;
    public GameObject panelGameOver;
    public GameObject panelYouWin;
    public GameObject textScore;

    void Start()
    {
        textScore.SetActive(false);
        panelGameOver.SetActive(false);
        panelYouWin.SetActive(false);
    }

    public void LancerJeu()
    {
        panelStart.SetActive(false);
        textScore.SetActive(true);
    }

    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }

    public void YouWin()
    {
        panelYouWin.SetActive(true);
    }

    public void Rejouer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}