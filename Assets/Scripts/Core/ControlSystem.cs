using System;
using UnityEngine;

namespace Core.ControlSystem
{
    public class ControlSystem
    {
        public static void Move(Transform rover,Transform target,float moveSpeed)
        {

            float step = moveSpeed * Time.deltaTime;

            if (Vector3.Distance(rover.position, target.position) < 0.001f)
                rover.position = rover.position;
            else if (Vector3.Distance(rover.position, target.position) > 0)
                rover.position = Vector3.MoveTowards(rover.position, target.position, step);

        }

        public static void Rotate(Transform rover,float rotateSpeed,float yRotation)
        {
            Quaternion finalRotation = Quaternion.Euler(0, yRotation, 0);
            rover.rotation = Quaternion.Lerp(rover.rotation, finalRotation, rotateSpeed * Time.deltaTime);
        }
    }
}

