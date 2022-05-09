using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        if (Input.GetButton("Fire3") || (horizontal != 0 && vertical == 0))
        {
            _multiplier = 2;
        }
        else
        {
            _multiplier = 1;
        }

        _animator.SetFloat("Horizontal", horizontal * _multiplier);
        _animator.SetFloat("Vertical", vertical * _multiplier);



    }

    private float _multiplier = 1;
    private Animator _animator;
}
