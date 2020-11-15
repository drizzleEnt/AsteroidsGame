using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGamePanel : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
