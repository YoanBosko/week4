using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefss : MonoBehaviour
{
    public Transform player;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = new Vector2(PlayerPrefs.GetFloat("posistionx"), PlayerPrefs.GetFloat("posistiony"));
        // float positionx = PlayerPrefs.GetFloat("posistionx");
        // float positiony = PlayerPrefs.GetFloat("posistiony");
        player.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = player.position.x;
        pos.y = player.position.y;
        PlayerPrefs.SetFloat("positionx",pos.x);
        PlayerPrefs.SetFloat("positiony",pos.y);
    }

}
