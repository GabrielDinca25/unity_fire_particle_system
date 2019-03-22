using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform Fire;
    private Vector3 pos;

    void FixedUpdate()
    {
        //float angle = Mathf.Atan2(transform.position.y, transform.position.x) * Mathf.Rad2Deg;
        //if (angle < 0) angle += 360.0f;
        ////transform.localEulerAngles = new Vector3(0, 0, angle);

        //float xPos = -Mathf.Cos(Mathf.Deg2Rad * angle);
        //float yPos = -Mathf.Sin(Mathf.Deg2Rad * angle);
        //transform.localPosition = new Vector3(Fire.transform.position.x + xPos, Fire.transform.position.y + yPos + 0.5f, 0);
        transform.RotateAround(Vector3.zero, Vector3.up, 10f * Time.fixedDeltaTime);
    }
}
