using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject player_camera;
    public GameObject[] interactables;

    public GameObject schedule_window;

    bool schedule_close;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        schedule_close = schedule_window.GetComponent<closeWindow>().getWindowClose();

        for (int i = 0; i < interactables.Length; i++)
        {
            if (interactables[i].GetComponent<interactable>().getInteracting() && Input.GetButtonDown("Jump"))
            {
                player_camera.GetComponent<PlayerLook>().UnlockCursor();
            }
        }


        if (schedule_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            schedule_window.GetComponent<closeWindow>().setWindowClose(false);
        }

    }



}
