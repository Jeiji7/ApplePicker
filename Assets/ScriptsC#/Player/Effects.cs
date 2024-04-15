using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public GameObject effectParticleOne;
    public GameObject effectParticleTwo;
    public GameObject effectParticleTree;
    public bool starti = false;

    private void Update()
    {
        if (starti == true)
        {
            StartCoroutine(Effect());

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Apple"))
        {
            starti = true;
            Effect();
        }
    }


    public IEnumerator Effect()
    {
        if (StatesPlayer.countLive == 4)
        {
            if (effectParticleOne != null)
            {
                effectParticleOne.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                effectParticleOne.SetActive(false);
                starti = false;
            }
        }
        else if (StatesPlayer.countLive == 3)
        {
            if (effectParticleTwo != null)
            {
                effectParticleTwo.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                effectParticleTwo.SetActive(false);
                starti = false;
            }
        }
        else if (StatesPlayer.countLive == 2)
        {
            if (effectParticleTree != null)
            {
                effectParticleTree.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                effectParticleTree.SetActive(false);
                starti = false;
            }
        }
    }
}
