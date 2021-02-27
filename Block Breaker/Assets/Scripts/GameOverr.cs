using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverr : MonoBehaviour
{

    public UnityEngine.UI.Text point;
    // Start is called before the first frame update
    void Start()
    {
        point.text="Your Point "+ GameObject.FindObjectOfType<Point>().GetComponent<Point>().returnPoint();

    }

   
}
