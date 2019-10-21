using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorChanger : MonoBehaviour
{
    public Light lightToChangeColorOf;

    private float timer;
    private float startTimer;

    void Start()
    {
        lightToChangeColorOf.color = new Color(1, .5f, 0);
    }

    private void Update()
    {
        startTimer += Time.deltaTime;

        if (startTimer >= 5)
            timer += Time.deltaTime;

        float r = (Mathf.Sin(timer) / 2) + .5f;

        lightToChangeColorOf.color = new Color(r, 0, 0);
    }
}
