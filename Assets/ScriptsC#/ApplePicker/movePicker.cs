using System.Collections;
using UnityEngine;

public class movePicker : MonoBehaviour
{
    public static float moveTree;
    public static float direction;
    public int rand = 2;

    void Start()
    {
        moveTree = 17;
        direction = 0;
        if (Random.value <= 0.5)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
    }
    void Update()
    {
        int randi = Random.Range(1, 1201);
        if (randi < rand)
        {
            direction *= -1;
        }
        MoveCharacter();
    }
    public void MoveCharacter()
    {
        transform.Translate(Vector3.right * direction * moveTree * Time.deltaTime);
    }
    //public void Randoms()
    //{
    //    StartCoroutine(StartTimer(4f));
    //    int random = Random.Range(1, 1001);
    //    rand = random;
    //}
    //IEnumerator StartTimer(float time)
    //{
    //    yield return new WaitForSeconds(time);

    //    Debug.Log("������ 2 �������!");
    //}
}
