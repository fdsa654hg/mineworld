using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightlight : MonoBehaviour {
    [SerializeField] float speed;
    float prevangle;
    public bool isnight = false;
	// Use this for initialization
	void Start () {
        prevangle = transform.rotation.eulerAngles.x;

    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Time.deltaTime*speed,0,0);
        Debug.Log(transform.rotation.eulerAngles.x);
        if (transform.rotation.eulerAngles.x > 300 && prevangle < 1)
        {
            isnight = true;
        }
        if(transform.rotation.eulerAngles.x < 1 && prevangle > 300)
        {
            isnight = false;
        }
        prevangle = transform.rotation.eulerAngles.x;

    }
}
