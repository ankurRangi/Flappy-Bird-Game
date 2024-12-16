using Unity.VisualScripting;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        // Future proofing - Collision was with the Bird only (check layer in bird component)
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
