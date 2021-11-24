using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtsacleRotation : MonoBehaviour
{
    public float turnSpeed;
    private void TurnAround()
    {
        gameObject.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.Self);
    }
    private void Update()
    {
        TurnAround();
    }
}
