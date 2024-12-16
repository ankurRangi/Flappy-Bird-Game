using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool isBirdAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // gameObject.name = "Ankur Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        // // Stop the bird from free-fall 
        // if (!isBirdAlive){
        //     Physics2D.gravity = Vector2.zero;
        // }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBirdAlive = false;
    }
}
