using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Events;

public class Chase : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public float distance;

    public float range;
    public UnityEvent General;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        range = UnityEngine.Vector2.Distance(transform.position, Player.transform.position);
        // UnityEngine.Vector2 direction = Player.transform.position - transform.position;
        // direction.Normalize(); 

        if (range < distance)
        {
            General?.Invoke();
            transform.position = UnityEngine.Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
            if (transform.position.x < Player.transform.position.x)
            {
                transform.localScale = new UnityEngine.Vector3(-1, 1, 1);
            }
            else if (transform.position.x > Player.transform.position.x)
            {
                transform.localScale = new UnityEngine.Vector3(1, 1, 1);
            }
        }

    }
}
