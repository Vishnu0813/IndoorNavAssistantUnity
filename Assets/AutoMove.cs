using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float turnSpeed = 100f;
    public float detectionDistance = 1.5f;

    private bool avoiding = false;
    private float avoidTimer = 0f;
    private float maxAvoidTime = 1.0f;
    private int turnDirection = 1; // 1 = right, -1 = left

    void Update()
    {
        RaycastHit hit;
        // Detect anything tagged as "Obstacle" in front
        if (Physics.Raycast(transform.position, transform.forward, out hit, detectionDistance))
        {
            if (hit.collider.CompareTag("Obstacle"))
            {
                avoiding = true;
                avoidTimer = 0f;
                turnDirection = Random.value > 0.5f ? 1 : -1; // alternate turning
            }
        }

        if (avoiding)
        {
            avoidTimer += Time.deltaTime;
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * turnDirection);

            if (avoidTimer >= maxAvoidTime)
            {
                avoiding = false;
            }
        }
        else
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
