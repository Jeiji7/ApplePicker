using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    [Range(5f, 15f)]
    public float speedMove = 10f;
    public static float sideMove = 0;

    [Header("DashScripts")]
    [Range(15f, 40f)]
    public float dashSpeed = 8f;
    public float dashDuration = 1f;
    public float dashCooldown = 5f;
    public Rigidbody2D rb;
    public static bool isDashing; // остановка всех процессов которые могут перебить дэш
    public bool canDash = true; // проеверка на возможность совершить дэш
    public Slider slider; // слайдер

    private void Awake()
    {
        slider = GameObject.FindObjectOfType<Slider>(); // Найти объект Slider по тегу или имени
    }
    private void Update()
    {
        if (isDashing)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canDash)
        {
            StartCoroutine(Dash());
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
            canDash = false;
            isDashing = true;
            slider.value = 0f;
            rb.velocity = new Vector2(sideMove * dashSpeed, 0f);
            yield return new WaitForSeconds(dashDuration);
            isDashing = false;

            float elapsedTime = 0f;
            while (elapsedTime < dashCooldown) 
            {
                elapsedTime += Time.deltaTime;
                slider.value = Mathf.Lerp(0f, 1f, elapsedTime * 0.2f);
                yield return null;
            }

            canDash = true;
        }
    }
}
