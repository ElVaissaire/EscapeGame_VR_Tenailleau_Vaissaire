using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorSocketCode : MonoBehaviour
{

    public void OnSelect(SelectEnterEventArgs args)
    {
        Debug.Log("Ouverture porte");
        GameManager.instance.OuverturePorteSortie();
    }
}
