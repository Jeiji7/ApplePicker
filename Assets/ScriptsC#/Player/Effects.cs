using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public GameObject effectOne;
    public GameObject effectTwo;
    public GameObject effectTree;

    public IEnumerator Effect()
    {
        if (StatesPlayer.countLive == 4)
        {
            effectOne.SetActive(true);
            yield return new WaitForSeconds(1);
            effectOne.SetActive(false);
        }
        else if (StatesPlayer.countLive == 3)
        {
            effectTwo.SetActive(true);
            yield return new WaitForSeconds(1);
        }
        else if (StatesPlayer.countLive == 2)
        {
            effectTree.SetActive(true);
            yield return new WaitForSeconds(1);
            effectTree.SetActive(false);
        }
    }
}
