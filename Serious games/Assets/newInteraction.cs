using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject pressMe;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == player.tag)
        {
            Debug.Log("welcome in");
            pressMe.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        Debug.Log("bye bye");
        pressMe.SetActive(false);
    }
}
