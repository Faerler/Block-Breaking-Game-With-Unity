using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{
    public void playGame() {
        BlockBreaking.totalBlock = 0;
        GameObject.FindObjectOfType<Point>().GetComponent<Point>().pointReset();
        SceneManager.LoadScene("Bolum1");
        
        
    }
}
