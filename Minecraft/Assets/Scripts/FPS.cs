using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour {
    int ct = 0;
    int t = 0;
    Text tt;
	// Use this for initialization
	void Start () {
        tt = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        ++ct;
		if(Time.time - t >= 1)
        {
            t++;
            tt.text ="FPS:" + ct.ToString();
            ct = 0;
        }
        if(GameObject.Find("Directional Light").GetComponent<DayNightlight>().isnight)
        {
            tt.color = Color.white;
        }
        else
        {
            tt.color = Color.black;
        }
	}
}
