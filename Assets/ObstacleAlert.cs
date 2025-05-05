using UnityEngine;

public class ObstacleAlert : MonoBehaviour
{
    public Transform player;
    public float alertDistance = 2f;

    void Update()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obs in obstacles)
        {
            float distance = Vector3.Distance(player.position, obs.transform.position);
            Renderer rend = obs.GetComponent<Renderer>();

            if (rend != null)
            {
                if (distance < alertDistance)
                {
                    rend.material.color = Color.red;
                    Debug.Log("ALERT: Obstacle nearby!");
                }
                else
                {
                    rend.material.color = Color.white;
                }
            }
        }
    }
}
