﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(40, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = plane.transform.position + offset;
        transform.rotation = Quaternion.Euler(0, -90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
