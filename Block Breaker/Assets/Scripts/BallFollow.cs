using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollow : MonoBehaviour
{
    private GameObject pedal;
    private bool gameStart = false;
    public float randomFloat;
    // Start is called before the first frame update
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
        randomFloat = Random.Range(-7.0f, 7.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStart)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
            if (Input.GetMouseButtonDown(0))
            {
                Go();
                gameStart = true;
            }
        }
        
    }

    void Go(){

        GetComponent<Rigidbody2D>().velocity = new Vector2(randomFloat, 10f);
    }
}
