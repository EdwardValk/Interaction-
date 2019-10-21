using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceOtherStuff : MonoBehaviour
{
    public GameObject theGameObjectThatIWantToReferenceToDoStuff;
    public bool trueLeftRightFalseUpDown;

    private Vector3 offset;
    public Vector3 scale;

    private float timer;

    private float startTimer;

    void Start()
    {
        offset = theGameObjectThatIWantToReferenceToDoStuff.transform.position;
        scale = theGameObjectThatIWantToReferenceToDoStuff.transform.localScale;
    }

    void Update()
    {
        startTimer += Time.deltaTime;

        if (startTimer >= 3)
            timer += Time.deltaTime;

        if (trueLeftRightFalseUpDown)
            theGameObjectThatIWantToReferenceToDoStuff.transform.position = 
                new Vector3(Mathf.Sin(timer * timer), 0, 0) + offset;
        else
            theGameObjectThatIWantToReferenceToDoStuff.transform.position = 
                new Vector3(0, Mathf.Sin(timer), 0) + offset;
    }
}
