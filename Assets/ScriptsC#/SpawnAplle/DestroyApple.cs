using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DestroyApple : MonoBehaviour
{
    public GameObject Apple;
    public static int countLive = 4;
    public static int scorePlayer = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            Destroy(Apple);
            print("- 1 жизнь");
            countLive -= 1;
        }
        else if (collision.CompareTag("Player"))
        {
            Destroy(Apple);
            print("+++++ 1 жизнь");
            scorePlayer += 1;
        }
    }
}

