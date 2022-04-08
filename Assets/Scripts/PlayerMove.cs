using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float movement_speed = 0.5f;
	public float movement_time = 0.1f;
	public float rotation_speed = 2f;
	public float rotation_time = 1f;
	
	private float distance;
	private float visual;
	
	private bool isRotate = false;
	
	public GameObject body;
	public GameObject vision;

    void Start()
    {

    }

    public void Update()
    {
		// Kalkulasi
		distance = movement_speed * movement_time;
		visual = rotation_speed * rotation_time;
		
		// Kendali WASD
		// Diagonal
		if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) && isRotate == false) // Maju Diagonal Kiri
		{body.transform.Translate(-distance, 0f, distance);}
		else if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) && isRotate == false) // Maju Diagonal Kanan
		{body.transform.Translate(distance, 0f, distance);}
		else if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && isRotate == false) // Mundur Diagonal Kiri
		{body.transform.Translate(-distance, 0f, -distance);}
		else if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && isRotate == false) // Mundur Diagonal Kanan
		{body.transform.Translate(distance, 0f, -distance);}
		
		// Lurus
        else if(Input.GetKey(KeyCode.W) && isRotate == false) // Maju
		{body.transform.Translate(0f, 0f, distance);}
		else if(Input.GetKey(KeyCode.S) && isRotate == false) // Mundur
		{body.transform.Translate(0f, 0f, -distance);}
		else if(Input.GetKey(KeyCode.A) && isRotate == false) // Kiri
		{body.transform.Translate(-distance, 0f, 0f);}
		else if(Input.GetKey(KeyCode.D) && isRotate == false) // Kanan
		{body.transform.Translate(distance, 0f, 0f);}
		
		// Rotasi Mata
		if(Input.GetKey(KeyCode.LeftArrow)) // Kiri
		{vision.transform.Rotate(0f, -visual, 0f);}
		else if(Input.GetKey(KeyCode.RightArrow)) // Kanan
		{vision.transform.Rotate(0f, visual, 0f);}
		
    }
}
