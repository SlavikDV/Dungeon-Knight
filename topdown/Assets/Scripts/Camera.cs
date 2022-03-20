using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform lookAt;
    public float boudX = 0.15f;
    public float boudY = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float deltaX = lookAt.position.x - transform.position.x;
        if (deltaX > boudX || deltaX < -boudX)
        {
            if (transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boudX;
            }
            else
            {
                delta.x = deltaX + boudX;
            }
        }
        
        float deltaY = lookAt.position.x - transform.position.x;
        if (deltaY > boudY || deltaY < -boudY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boudY;
            }
            else
            {
                delta.y = deltaY + boudY;
            }
        }
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
