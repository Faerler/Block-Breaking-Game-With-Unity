﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DownWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D diger) {
        if (diger.gameObject.name.Equals("Ball")) {
            SceneManager.LoadScene("KaybetmeSahnesi");
        }
    }
}
