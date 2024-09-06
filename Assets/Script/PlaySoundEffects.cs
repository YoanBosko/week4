using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffects : MonoBehaviour
{
    AudioSource source;
    AudioManager manager;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        manager = GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Quiet()
    {
        source.clip = null;
    }
    public void Walk()
    {
        source.clip = manager.Walk;
        source.Play();
    }
    public void Dialog()
    {
        source.clip = manager.Dialog;
        source.Play();
    }
    public void ItemObtain()
    {
        source.clip = manager.ItemObtain;
        source.Play();
    }
    public void Coin()
    {
        source.clip = manager.Coin;
        source.Play();
    }
    public void Death() 
    {
        source.clip = manager.Death;
        source.Play();
    }
}
