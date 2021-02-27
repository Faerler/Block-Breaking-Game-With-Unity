using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreaking : MonoBehaviour
{
    public static int totalBlock;
    public Sprite[] blockSprite;
    private int maxHit;
    private int Hit=0;
    private  Point pointScript;
    // Start is called before the first frame update
    void Start()
    {
        maxHit = blockSprite.Length + 1;
        totalBlock++;
        pointScript = GameObject.FindObjectOfType<Point>().GetComponent<Point>();
    }


    void OnCollisionEnter2D(Collision2D diger) {
        if (diger.gameObject.name.Equals("Ball")) {
            Hit++;
            pointScript.pointInc();

            if (Hit >= maxHit)
            {
                totalBlock--;
                Destroy(this.gameObject);
                if (totalBlock <= 0)
                {
                    GameObject.FindObjectOfType<GameControl>().GetComponent<GameControl>().NextLevel();
                }
            }
            else {
                GetComponent<SpriteRenderer>().sprite = blockSprite[Hit - 1];
            }
        }
    }
}
