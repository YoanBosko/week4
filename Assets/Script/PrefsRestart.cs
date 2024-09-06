using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PrefsRestart : MonoBehaviour
{
    public UnityEvent General;
    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        General?.Invoke();
    }
}
