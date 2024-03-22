using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DashPlayer : MonoBehaviour
{
    [Range(5f, 20f)]
    public float dashDistance = 8f;
    public float cooldown = 5f;
    public float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer >= cooldown)
            {
                Dash();
                print("dashhhhhh");
                timer = 0f;
            }
        }
    }

    public void Dash()
    {
        if (MovePlayer.sideMove != 0)
        {
            Vector2 startPos = transform.position;
            Vector2 endPos = startPos + new Vector2(dashDistance * GetDashDirection(), 0f);
            StartCoroutine(MovePlayerSmoothly(transform, startPos, endPos, 0.5f));
        }
    }

    private float GetDashDirection()
    {
        return MovePlayer.sideMove;
    }

    private IEnumerator MovePlayerSmoothly(Transform transform, Vector2 start, Vector2 end, float duration)
    {
        float startTime = Time.time;
        while (Time.time < startTime + duration)
        {
            float t = (Time.time - startTime) / duration;
            transform.position = Vector2.Lerp(start, end, t);
            yield return null;
        }
        transform.position = end;
    }
}
