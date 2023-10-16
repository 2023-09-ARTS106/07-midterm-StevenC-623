using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToHide;

    private void OnTriggerEnter(Collider other)
    {
        objectToHide.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        objectToHide.SetActive(true);
    }
}
