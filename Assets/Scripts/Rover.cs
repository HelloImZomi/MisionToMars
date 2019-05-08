using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.ControlSystem;

public class Rover : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 50f;

    [SerializeField]
    float rotateSpeed = 5f;

    [SerializeField]
    float yRotate = 0f;

    [SerializeField]
    Vector2 coordinates;

    [SerializeField]
    bool EnableCoordinates = true;

    [SerializeField]
    Transform target;

    [SerializeField]
    float minDistance = 2f;

    private void Awake()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
    public float YRotate { get => yRotate; set => yRotate = value; }
    public float RotateSpeed { get => rotateSpeed; set => rotateSpeed = value; }
    public Vector2 Coordinates { get => coordinates; set => coordinates = value; }

    protected virtual void Move()
    {
        //Vector3 newPosition = new Vector3(coordinates.x, 0, coordinates.y);

        //if (EnableCoordinates) { target.position = newPosition; }
        ControlSystem.Move(transform,target,MoveSpeed);
    } 

    protected virtual void Rotate()
    {
        ControlSystem.Rotate(transform,RotateSpeed, YRotate);
    }
}
