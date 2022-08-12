using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingObject : MonoBehaviour
{
    // This object needs to teleport when the "OnCollision" event is announced

    private void OnEnable()
    {
        EventSystem.OnPressSpacebar += Teleport;
        EventSystem.OnPressReturn += MoveToZero;
    }

    private void OnDisable()
    {
        EventSystem.OnPressSpacebar -= Teleport;
        EventSystem.OnPressReturn -= MoveToZero;
    }

    private void Teleport()
    {
        transform.position = new Vector3(0, 6, 0);
    }

    private void MoveToZero()
    {
        transform.position = Vector3.zero;
    }
}
