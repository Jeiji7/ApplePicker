using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Range(5f, 15f)]
    public float speedMove = 10f;
    public static float sideMove = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            sideMove = -1; 
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            sideMove = 1; 
        }
        MoveCharacter();
    }

    public void MoveCharacter()
    {
        transform.Translate(Vector3.right * sideMove * speedMove * Time.deltaTime);
    }
}
