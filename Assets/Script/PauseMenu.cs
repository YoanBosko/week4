using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    [Header("Pause Menu")]
    public GameObject canvas;
    public UnityEvent paused;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
            paused?.Invoke();
            // Debug.Log("bisa");
        }

    }

    public void Toggle()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;
            canvas.SetActive(true); 
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            AudioListener.pause = false;
            canvas.SetActive(false); 
            isPaused = false;
        }
    }
}
