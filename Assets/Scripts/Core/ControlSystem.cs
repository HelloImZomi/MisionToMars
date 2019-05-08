using System;
using UnityEngine;

namespace Core.ControlSystem
{
    public class ControlSystem
    {
        public static void Move(Transform rover,Transform target,float moveSpeed)
        {
            if (target)
            {
                rover.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                rover.LookAt(target);
            }            
        }

        public static void Rotate(Transform rover,float rotateSpeed,float yRotation)
        {
            Quaternion finalRotation = Quaternion.Euler(0, yRotation, 0);
            rover.rotation = Quaternion.Lerp(rover.rotation, finalRotation, rotateSpeed * Time.deltaTime);
        }
    }
}

