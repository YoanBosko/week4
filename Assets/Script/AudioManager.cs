using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    public AudioSource BGM;
    public AudioSource SFX;

    [Header("Audio Clip")]
    public AudioClip BackSound1;
    public AudioClip BackSound2;
    public AudioClip BackSound3;
    public AudioClip Walk;
    public AudioClip Dialog;
    public AudioClip Death;
    public AudioClip Coin;
    public AudioClip ItemObtain;
    public AudioClip Button;

    public AudioManager instance;

    private void Awake()
    {
        // if (instance == null)
        // {
        //     instance = this;
        //     DontDestroyOnLoad(gameObject);
        // }
        // else
        // {
        //     Destroy(gameObject);
        // }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Title Screen")
        {
            BGM.clip = BackSound1;
            BGM.Play();
        }
        else if (scene.name == "Map 4")
        {
            BGM.clip = BackSound3;
            BGM.Play();
        }
        else
        {
            BGM.clip = BackSound2;
            BGM.Play();
        }
    }
    // public void NoDestroy()
    // {
    //     DontDestroyOnLoad(gameObject);
    // }
}
