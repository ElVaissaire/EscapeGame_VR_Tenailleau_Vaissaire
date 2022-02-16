using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private Animator door;
    private bool openState = false;

    public void ouvertureManager()
    {
        if (openState)
        {
            openState = false;
            door.SetTrigger("close");
        }
        else
        {
            openState = true;
            door.SetTrigger("open");
        }
    }
}
