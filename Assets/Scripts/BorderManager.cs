using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorderManager : Singleton<BorderManager>
{
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(0);
    }
}
