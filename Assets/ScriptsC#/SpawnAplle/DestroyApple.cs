using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyApple : MonoBehaviour
{
    public GameObject Apple;
    public static int countyy = 4;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            Destroy(Apple);
            print("- 1 жизнь");
            countyy -= 1;
        }
        else if (collision.CompareTag("Player"))
        {
            Destroy(Apple);
            print("+++++ 1 жизнь");
        }
        
    }
}
