using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStartsControl : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void ReStarts()
    {
        SceneManager.LoadScene(1);
    }
}