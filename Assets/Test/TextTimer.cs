using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    public float timerDelay = 1.0f;
    private float nextEventTimer;
    // Start is called before the first frame update
    void Start()
    {
        nextEventTimer = Time.time + timerDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextEventTimer)
        {
            Debug.Log("Fire");
            nextEventTimer -= Time.time + timerDelay;
            nextEventTimer = timerDelay = 0.0f;
        }
    }
}
