using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    
    [SerializeField] AudioSource coinFX; 

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        Masternfo.coinCount += 1;
        this.gameObject.SetActive(false);
    }

}

