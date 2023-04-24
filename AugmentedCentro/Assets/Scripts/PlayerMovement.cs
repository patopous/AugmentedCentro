using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _speed;
    private Rigidbody _rb;
    public bool _left = false, _right = false;
    private float _vel;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
        if (_left == true && _right == false)
        {
            Left();
        }
        
        if (_right == true && _left == false)
        {
            Right();
        }

        if (_right == false && _left == false)
        {
            Stop();
        }
    }
    
    private void Left() 
    {
        _vel = -1;
        Debug.Log("Left");
    }

    private void Right()
    {
        _vel = +1;
        Debug.Log("Right");
    }

    private void Stop()
    {
        _vel = 0;
    }

    private void Move()
    {
        Vector3 velocity = new Vector3(_speed+_vel, 0, 0);
        _rb.velocity = velocity;
    }


}
