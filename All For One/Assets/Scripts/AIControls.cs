﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControls : MonoBehaviour
{
    [SerializeField] GameObject start;
    [SerializeField] GameObject end;

    [SerializeField] float time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Walk());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Walk()
    {
        time = 0;
        while (true)
        {
            time = 0;
            while (transform.position != end.transform.position)
            {
                transform.position = Vector3.Lerp(transform.position, end.transform.position, time / 100.0f);
                time += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            time = 0;
            while (time < 3.0f)
            {
                time += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            time = 0;
            while (transform.position != start.transform.position)
            {
                transform.position = Vector3.Lerp(transform.position, start.transform.position, time / 100.0f);
                time += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            time = 0;
            while (time < 3.0f)
            {
                time += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
        }
    }
}