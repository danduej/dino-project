using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitsControl : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void Exits()
    {
        SceneManager.LoadScene(0);
    }
}
