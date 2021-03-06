﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public int code;
    float disableTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disableTimer > 0)
            disableTimer -= Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player" && disableTimer <= 0)
        {
            foreach(Teleporter tp in FindObjectsOfType<Teleporter>())
            {
                if(tp.code==code && tp != this)
                {
                    tp.disableTimer = 2;
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;
                }
            }
        }
    }
}
