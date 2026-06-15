using UnityEngine;

public class CatFollower : MonoBehaviour

{
    public Transform target;
    public float followSpeed = 4f;
    public float followDistance = 6f;
    public float catchDistance = 1.5f;

    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 targetPosition = target.position - target.forward * followDistance;
        targetPosition.y = transform.position.y;

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            followSpeed * Time.deltaTime
        );

        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance <= catchDistance)
        {
            Debug.Log("Game Over: the cat caught the mouse!");
        }
    }
}