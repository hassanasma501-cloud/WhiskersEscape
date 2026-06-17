using UnityEngine;

public class CatFollower : MonoBehaviour
{
    public Transform target;
    public string playerTag = "Player";

    public float followSpeed = 10f;
    public float catchDistance = 4f;

    public GameObject gameOverPanel;

    private bool hasCaughtPlayer = false;

    void Start()
    {
        Time.timeScale = 1f;

        if (target == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag(playerTag);

            if (playerObject != null)
            {
                target = playerObject.transform;
            }
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    void Update()
    {
        if (target == null || hasCaughtPlayer)
        {
            return;
        }

        Vector3 targetPosition = target.position;
        targetPosition.y = transform.position.y;

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            followSpeed * Time.deltaTime
        );

        Vector3 direction = target.position - transform.position;
        direction.y = 0f;

        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance <= catchDistance)
        {
            CatchPlayer();
        }
    }

    void CatchPlayer()
    {
        hasCaughtPlayer = true;

        Debug.Log("Game Over: the cat caught the mouse!");

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }
}