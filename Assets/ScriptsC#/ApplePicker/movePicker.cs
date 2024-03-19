using System.Collections;
using UnityEngine;

public class movePicker : MonoBehaviour
{
    [Range(10f, 20f)]
    public float moveTree = 10;
    public static float direction = 0;
    public int rand = 2;

    void Start()
    {
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
        int randi = Random.Range(1, 1001);
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

    //    Debug.Log("Прошло 2 секунды!");
    //}
}
