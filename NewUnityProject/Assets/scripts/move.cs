using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Transform _transform;
    public float speed;
    public float jump;
    public bool flag;
    private void Start()
    {
        speed = 1.0f;
        jump = 20.0f;
        flag = false;
    }

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _transform.position += new Vector3(speed*Time.deltaTime,0,0);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position -= new Vector3(speed*Time.deltaTime,0,0);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _transform.position -= new Vector3(0,jump*Time.deltaTime,0);
            flag = true;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _transform.position += new Vector3(0,jump*Time.deltaTime,0);
            flag = false;
        }
    }

}
