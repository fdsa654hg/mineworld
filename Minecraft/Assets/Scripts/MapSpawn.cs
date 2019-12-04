using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawn : MonoBehaviour {
    [SerializeField] Transform grass, dirt, stone;
	// Use this for initialization
	void Start () {
        Transform bar;
		for(int i = 0; i <= 100; i++)
        {
            for(int j = 0; j <= 100; j++)
            {
                bar = Instantiate(grass);
                bar.position = new Vector3(-50+i,-0.5f,-50+j);
                /*for(int x = 0; x < 3; x++)
                {
                    bar = Instantiate(dirt);
                    bar.position = new Vector3(-50 + i, -1.5f - x, -50 + j);
                }
                for (int x = 0; x < 5; x++)
                {
                    bar = Instantiate(stone);
                    bar.position = new Vector3(-50 + i, -2.5f - x, -50 + j);
                }*/
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
