using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawn : MonoBehaviour {
    [SerializeField] Transform grass, dirt, stone;
    Transform chara;
    List<Transform> map = new List<Transform>();
	// Use this for initialization
	void Start () {
        Transform bar;
        chara = GameObject.Find("Main Camera").GetComponent<Transform>();
        for (int i = 0; i <= 100; i++)
        {
            for(int j = 0; j <= 100; j++)
            {
                bar = Instantiate(grass);
                bar.position = new Vector3(-50+i,-0.5f,-50+j);
                map.Add(bar);
                /*for(int x = 0; x < 3; x++)
                {
                    bar = Instantiate(dirt);
                    bar.position = new Vector3(-50 + i, -1.5f - x, -50 + j);
                    map.Add(bar);
                }
                for (int x = 0; x < 3; x++)
                {
                    bar = Instantiate(stone);
                    bar.position = new Vector3(-50 + i, -2.5f - x, -50 + j);
                    map.Add(bar);
                }*/
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        
		for(int i = 0; i < map.Count; i++)
        {
            if (Vector3.Distance(map[i].position, chara.position) > 15 && map[i].gameObject.activeSelf)
            {
                map[i].gameObject.SetActive(false);
            }
            else if (Vector3.Distance(map[i].position, chara.position) < 15  && !map[i].gameObject.activeSelf)
            {
                map[i].gameObject.SetActive(true);
            }
        }
	}
}
