using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public delegate void SpacebarPressAction();
    public delegate void ReturnPressAction();

    public static event SpacebarPressAction OnPressSpacebar;
    public static event ReturnPressAction OnPressReturn;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(OnPressSpacebar != null)
            {
                OnPressSpacebar();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (OnPressReturn != null)
            {
                OnPressReturn();
            }
        }
    }
}
