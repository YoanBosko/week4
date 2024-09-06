using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Collision2DTrigger : MonoBehaviour
{
    [Header("Settings")]
    public string Tag;
    public GameObject[] backsound;
    public UnityEvent StartEvents;
    public UnityEvent OnTriggerEnterEvent;

    private void Awake()
    {
    //     Destroy(backsound);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartEvents?.Invoke();
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
    public void CutSound()
    {
        backsound = GameObject.FindGameObjectsWithTag("Audio");
        foreach (GameObject backs in backsound)
        {
            SceneManager.MoveGameObjectToScene(backs, SceneManager.GetActiveScene());   
        }
    }
}
