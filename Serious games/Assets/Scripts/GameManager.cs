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
    public GameObject pc_window;
    public GameObject bed_window;
    public GameObject book_window;

    public GameObject mental_panel;

    public GameObject healthBar;
    public GameObject stressBar;

    bool schedule_close;
    bool door_close;
    bool pc_close;
    bool bed_close;
    bool book_close;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.GetComponent<HealthBar>().SetMaxHealth(100);
        stressBar.GetComponent<HealthBar>().SetMaxHealth(100);
        stressBar.GetComponent<HealthBar>().SetHealth(0);
        mental_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        schedule_close = schedule_window.GetComponent<WindowManager>().getWindowClose();
        door_close = door_window.GetComponent<WindowManager>().getWindowClose();
        pc_close = pc_window.GetComponent<WindowManager>().getWindowClose();
        bed_close = bed_window.GetComponent<WindowManager>().getWindowClose();
        book_close = book_window.GetComponent<WindowManager>().getWindowClose();


        for (int i = 0; i < interactables.Length; i++)
        {
            if (!player.GetComponent<PlayerMove>().getBreakdown())
            {
                if (interactables[i].GetComponent<interactable>().getInteracting() && Input.GetButtonDown("Jump"))
                {
                    player_camera.GetComponent<PlayerLook>().UnlockCursor();
                }

            }
            if (player.GetComponent<PlayerMove>().getBreakdown() && interactables[i].GetComponent<interactable>().bed)
            {
                if (interactables[i].GetComponent<interactable>().getInteracting() && Input.GetButtonDown("Jump"))
                {
                    player_camera.GetComponent<PlayerLook>().UnlockCursor();
                }

            }

        }

        if (schedule_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            schedule_window.GetComponent<WindowManager>().setWindowClose(false);
        }
        if (door_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            door_window.GetComponent<WindowManager>().setWindowClose(false);

        }
        if (pc_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            pc_window.GetComponent<WindowManager>().setWindowClose(false);

        }
        if (bed_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            bed_window.GetComponent<WindowManager>().setWindowClose(false);

        }
        if (book_close)
        {
            player_camera.GetComponent<PlayerLook>().LockCursor();
            book_window.GetComponent<WindowManager>().setWindowClose(false);

        }

        if (stressBar.GetComponent<HealthBar>().slider.value == 100)
        {
            mental_panel.SetActive(true);
            player.GetComponent<PlayerMove>().setBreakdown(true);
        }
        else
        {
            mental_panel.SetActive(false);
            player.GetComponent<PlayerMove>().setBreakdown(false);

        }
    }



}
