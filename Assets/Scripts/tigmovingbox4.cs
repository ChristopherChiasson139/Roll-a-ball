using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigmovingbox4 : MonoBehaviour
{
    public GameObject AnimatedObject;

    private Animator _animator;

    private void Start()
    {
        _animator = AnimatedObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("bug");
        _animator.enabled = true;
        
    }

    void OnTriggerExit(Collider other)
    {
        _animator.enabled = false;

    }

    
    
}