using UnityEngine;

public class WallDirection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (MovePlayer.sideMove == 1)
            {
                MovePlayer.isDashing = false;
                MovePlayer.sideMove = -1;
            }
            else if (MovePlayer.sideMove == -1)
            {
                MovePlayer.isDashing = false;
                MovePlayer.sideMove = 1;
            }
            Debug.Log("Player entered the trigger");
        }
    }
}