using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigmovingbox4 : MonoBehaviour
{
    [SerializeField] private Animator myDoor;

    [SerializeField] private string doorOpen = "DoorOpen";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDoor.Play(doorOpen, 0, 0.0f);
        }
    }
}