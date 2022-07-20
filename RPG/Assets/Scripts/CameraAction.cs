using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAction : MonoBehaviour
{
    public Transform lookAt;
    public float BoundX = 0.15f;
    public float BoundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 Delta = Vector3.zero;

        float DeltaX = lookAt.position.x - transform.position.x;

        if (DeltaX > BoundX || DeltaX < -BoundX)
        {
            if (transform.position.x < lookAt.position.x)
            {
                Delta.x = DeltaX - BoundX;
            }
            else
            {
                Delta.x = DeltaX + BoundX;
            }
        }

        float DeltaY = lookAt.position.y - transform.position.y;

        if (DeltaY > BoundY || DeltaY < -BoundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                Delta.y = DeltaY - BoundY;
            }
            else
            {
                Delta.y = DeltaY + BoundY;
            }
        }
        transform.position += new Vector3(Delta.x, Delta.y, 0);
    }
}
