using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject pressMe;
    public GameObject stressed;

    public void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == player.tag)
        {
            if (!player.GetComponent<PlayerMove>().getBreakdown())
            {
                Debug.Log("welcome in");
                pressMe.SetActive(true);
            }
            else
            {
                stressed.SetActive(true);
            }
        }

            
        
    }

    public void OnTriggerExit(Collider collision)
    {
        Debug.Log("bye bye");
        pressMe.SetActive(false);
        stressed.SetActive(false);

    }
}
