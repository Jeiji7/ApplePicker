using System.Collections;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Range(5f, 15f)]
    public float speedMove = 10f;
    public static float sideMove = 0;

    [Header("DashScripts")]
    [Range(15f, 40f)]
    public float dashSpeed = 8f;
    public float dashDuration = 0f;
    public float dashCooldown = 1f;
    public Rigidbody2D rb;
    public static bool isDashing;

    private void Update()
    {
        dashCooldown += Time.deltaTime;
        if (isDashing)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && dashCooldown >= 5)
        {
            StartCoroutine(Dash());
            dashCooldown = 0;
        }
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
        transform.Translate(sideMove * speedMove * Time.deltaTime * Vector3.right);
    }
    void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
        rb.velocity = new Vector2(sideMove * speedMove, 0f);

    }
    private IEnumerator Dash()
    {
        if (sideMove != 0)
        {
            isDashing = true;
            rb.velocity = new Vector2(sideMove * dashSpeed, 0f);
            yield return new WaitForSeconds(dashDuration);
            isDashing = false;

        }
    }
}
