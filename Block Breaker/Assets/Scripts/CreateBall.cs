using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject ball;
    void OnCollisionEnter2D(Collision2D diger) {
        if (diger.gameObject.name.Equals("Ball")) {
            

            
                
                Destroy(this.gameObject);
                Quaternion quaternion= new Quaternion(0,0,0,0);
                Instantiate(ball,diger.transform.position,quaternion);
                
                
            
            
        }
    }
}
