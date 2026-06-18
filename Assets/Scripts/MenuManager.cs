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
        Time.timeScale = 0f;

        panelStart.SetActive(true);
        panelGameOver.SetActive(false);
        panelYouWin.SetActive(false);
        textScore.SetActive(false);
    }

    public void LancerJeu()
    {
        Time.timeScale = 1f;

        panelStart.SetActive(false);
        textScore.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;

        panelGameOver.SetActive(true);
    }

    public void YouWin()
    {
        panelYouWin.SetActive(true);
    }

    public void Rejouer()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}