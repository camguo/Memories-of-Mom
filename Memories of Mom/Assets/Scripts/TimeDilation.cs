using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDilation : MonoBehaviour
{
    private float fixedDeltaTime;

    void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        if (Time.timeScale != 0f)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
        Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
    }
}
