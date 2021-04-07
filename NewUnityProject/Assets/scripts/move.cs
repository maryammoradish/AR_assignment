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
    public GameObject bubble_Prefab;
    //[SerializeField] public GameObject prefaninstance;
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
            Instantiate(bubble_Prefab, new Vector3(_transform.position.x-1,_transform.position.y,_transform.position.z), Quaternion.identity);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position -= new Vector3(speed*Time.deltaTime,0,0);
            Instantiate(bubble_Prefab, new Vector3(_transform.position.x+1,_transform.position.y,_transform.position.z), Quaternion.identity);
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
