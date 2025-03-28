using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDeti : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeout;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());
    }
    IEnumerator CollisionEnd()
    {
        collisionFX.Play();
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        mainCam.GetComponent<Animator>().Play("ColilsionCam");
        yield return new WaitForSeconds(3);
        fadeout.SetActive(true);
    }

}


