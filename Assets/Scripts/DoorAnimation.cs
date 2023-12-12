using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private GameObject Other = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "DoorSouthOpen";
    [SerializeField] private string doorClose = "DoorSouthClose";

    public AudioSource audioSource;
    public AudioClip clip;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play(doorOpen,0,0.0f);

                audioSource.PlayOneShot(clip,0.9f);


                gameObject.SetActive(false);
                Other.SetActive(true);

            }
            else if (closeTrigger)
            {
                myDoor.Play(doorClose, 0, 0.0f);
                gameObject.SetActive(false);
                Other.SetActive(true);
            }
        }
    }
}
