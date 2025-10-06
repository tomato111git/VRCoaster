using System;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 lastlocation;
    AudioSource audio1;
    void Start()
    {
        lastlocation = transform.position;
        audio1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nowlocation = transform.position;
        audio1.volume = (float) Math.Sqrt((nowlocation - lastlocation).magnitude / Time.deltaTime / 600f) / 10;
        lastlocation = nowlocation;
    }
}
