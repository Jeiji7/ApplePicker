using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPoisonAplle : MonoBehaviour
{
    public GameObject ApllePosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            Destroy(ApllePosion);
        }
        else if (collision.CompareTag("Player"))
        {
            Destroy(ApllePosion);
            StatesPlayer.countLive -= 1;
        }
    }
}
