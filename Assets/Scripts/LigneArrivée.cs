using UnityEngine;

public class LigneeArrivee : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<MenuManager>().YouWin();
        }
    }
}
