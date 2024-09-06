using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObtain : MonoBehaviour
{
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Enabled()
    {
        PlayerPrefs.SetString("item", "True");
    }
    public void StopTime()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
}
