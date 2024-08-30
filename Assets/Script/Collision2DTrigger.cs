using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collision2DTrigger : MonoBehaviour
{
    [Header("Settings")]
    public string Tag;
    public UnityEvent OnTriggerEnterEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(Tag))
        {
            OnTriggerEnterEvent?.Invoke();
        }
    }
}
