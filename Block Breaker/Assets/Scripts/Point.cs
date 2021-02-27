using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private int point=0;
    public void pointInc() {
        point++;
    
    }
    public int returnPoint() {
        return this.point;
    }

    public void pointReset() {
        this.point = 0;
    }
    
}
