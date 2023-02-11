﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target Object")]
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if target y pos is greater than camera pos
        if(target.position.y > transform.position.x)
        {
            //camera follows target
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        }
    }
}