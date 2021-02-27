using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    static bool Music;
    // Start is called before the first frame update
    void Start()
    {
        if (!Music)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            Music = true;
        }
        else {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
