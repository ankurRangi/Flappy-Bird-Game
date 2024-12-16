using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        // if (logic.playerScore < logic.playerScore + 5)
        // {
        //     moveSpeed = moveSpeed + 5;
        // }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            // Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
