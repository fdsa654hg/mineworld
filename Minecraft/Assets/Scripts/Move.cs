using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    [SerializeField] float move_speed,mouse_sensitive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,Input.GetAxis("Mouse X")*Time.deltaTime*mouse_sensitive,0);
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime * move_speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * move_speed;
        }*/
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.rotation * Quaternion.Euler(0,90,0) * Vector3.forward * Time.deltaTime * move_speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.rotation * Quaternion.Euler(0, 90, 0) * Vector3.back * Time.deltaTime * move_speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.rotation * Quaternion.Euler(0, 90, 0) * Vector3.left * Time.deltaTime * move_speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.rotation * Quaternion.Euler(0,90,0) * Vector3.right * Time.deltaTime * move_speed;
        }
    }
}
