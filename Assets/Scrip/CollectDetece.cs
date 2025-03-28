using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        mainCam.GetComponent<Animator>().Play("Credits Animation");
        yield return new WaitForSeconds(3);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }

}


