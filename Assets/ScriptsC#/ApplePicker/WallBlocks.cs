using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBlocks : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Picker"))
        {
            if (movePicker.direction == 1)
            {
                movePicker.direction = -1;
            }
            else if (movePicker.direction == -1)
            {
                movePicker.direction = 1;
            }
            Debug.Log("Player entered the trigger");
        }
    }

}
