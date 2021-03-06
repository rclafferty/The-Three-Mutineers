﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.JoystickButton0))
        if (Input.anyKeyDown || Input.GetButtonDown("P1 Attack") || Input.GetButtonDown("P2 Attack") || Input.GetButtonDown("P3 Attack"))
        {
            StartButtonClicked();
        }
    }

    public void StartButtonClicked()
    {
        Debug.Log("Starting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButtonClicked()
    {
        Debug.Log("Quiting");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
