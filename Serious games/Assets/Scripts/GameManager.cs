using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject player_camera;
    public GameObject[] interactables;

    public GameObject schedule_window;
    public GameObject door_window;

    public GameObject healthBar;
    public GameObject stressBar;

    bool schedule_close;
    bool door_close;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.GetComponent<HealthBar>().SetMaxHealth(100);
        stressBar.GetComponent<HealthBar>().SetMaxHealth(100);
        stressBar.GetComponent<HealthBar>().SetHealth(0);

    }

    // Update is called once per frame
    void Update()
    {
        schedule_close = schedule_window.GetComponent<closeWindow>().getWindowClose();
        door_close = door_window.GetComponent<closeWindow>().getWindowClose();

        for (int i = 0; i < interactables.Length; i++)
        {
            if (interactables[i].GetComponent<interactable>().getInteracting() && Input.GetButtonDown("Jump"))
            {
                player_camera.GetComponent<PlayerLook>().UnlockCursor();
            }


        }

        if(schedule_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            schedule_window.GetComponent<closeWindow>().setWindowClose(false);
        }
        if(door_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            door_window.GetComponent<closeWindow>().setWindowClose(false);

        }
    }



}
