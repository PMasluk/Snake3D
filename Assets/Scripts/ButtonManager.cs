using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject startButton;

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            Hide();
        }
    }
}

