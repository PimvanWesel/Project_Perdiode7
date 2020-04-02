using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Animation DoorOpen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            DoorOpen.GetComponent<Animation>().Play("DoorOpen");
            Debug.Log("Door animation playing");
        }
    }
}
