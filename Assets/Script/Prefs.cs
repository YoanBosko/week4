using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prefs : MonoBehaviour
{
    public Transform player;
    Vector2 datas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Map1Save(string aValue)
    {
        PlayerPrefs.SetFloat(aValue + "1", player.position.x);
        PlayerPrefs.SetFloat(aValue + "2", player.position.y);
    }
    public void Map1Load(string aValue)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Map 1")
        {
            datas.x = PlayerPrefs.GetFloat(aValue + "1") - int.Parse(aValue);
            datas.y = PlayerPrefs.GetFloat(aValue + "2");
            player.position = datas;
        }
        else if (scene.name == "Map 2")
        {
            datas.x = PlayerPrefs.GetFloat(aValue + "1");
            datas.y = PlayerPrefs.GetFloat(aValue + "2") + 1f;
            player.position = datas;
        }
        else if (scene.name == "Overworld")
        {
            if (player.position.y < 4f)
            {
                datas.x = PlayerPrefs.GetFloat(aValue + "1") + 1f;
                datas.y = PlayerPrefs.GetFloat(aValue + "2");
                player.position = datas;
            }
            else if (player.position.y < 10f)
            {
                datas.x = PlayerPrefs.GetFloat(aValue + "1") - 1f;
                datas.y = PlayerPrefs.GetFloat(aValue + "2");
                player.position = datas;
            }
            else if (player.position.y < 20f)
            {
                datas.x = PlayerPrefs.GetFloat(aValue + "1");
                datas.y = PlayerPrefs.GetFloat(aValue + "2") - 1f;
                player.position = datas;
            }
        
        }
        
    }
    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }
}
