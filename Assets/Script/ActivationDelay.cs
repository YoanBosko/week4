using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivationDelay : MonoBehaviour
{
    [Header("Main Settings")]
    public UnityEvent MainEvent;

    [Header("Event Settings")]
    public UnityEvent StartEvents;
    public UnityEvent UpdateEvents;

    [Header("Delay Settings")]
    public bool usingDelay;
    public float Delay;
    public UnityEvent DelayEvents;

    // Start is called before the first frame update
    void Start()
    {
        StartEvents?.Invoke();
        if (usingDelay)
        {
            Invoke("InvokeDelay", Delay);
        }
    }

    public void InvokeMainEvents()
    {
        MainEvent?.Invoke();
    }

    public void InvokeMainEventDelay()
    {
        Invoke("InvokeMainEvents", Delay);
    }

    void InvokeDelay()
    {
        DelayEvents?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEvents?.Invoke();

    }

}
