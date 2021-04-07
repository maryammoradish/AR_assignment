using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiation : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject cube_pose;
    private float _time ;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        _time = Time.deltaTime;
        // Instantiate at position (0, 0, 0) and zero rotation.
    }

    private void Update()
    {
        _time += Time.deltaTime;
        if (_time>2)
        {
            Debug.Log("Destroy.........?");
            //DestroyImmediate(myPrefab,true);
        }
            
    }
}
