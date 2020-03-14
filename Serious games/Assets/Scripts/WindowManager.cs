using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject main_window;
    public GameObject confirm_window;

    public GameObject health;
    public GameObject stress;

    int health_modify;
    int stress_modify;

    bool window_close;

    // Start is called before the first frame update
    void Start()
    {
        health_modify = 0;
        stress_modify = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //SOMETHING TO ENABLE MOVEMENT;

    public void youSure()
    {
        confirm_window.SetActive(true);
    }

    public void closeAll()
    {
        main_window.SetActive(false);
        confirm_window.SetActive(false);
        applyModifications();
        window_close = true;
        //SOMETHING THAT ENABLES MOVEMENT, EVEN WITHIN INTERACTION RADIUS;
    }

    public void taskList()
    {
        confirm_window.SetActive(false);
    }

    public bool getWindowClose()
    {
        return window_close;
    }
    public void setWindowClose(bool close)
    {
        window_close = close;
    }

    public void goToSchool()
    {
        health_modify = -50;
        stress_modify = 30;
        FindObjectOfType<AudioManager>().Play("door");

        youSure();
    }

    public void goToWork()
    {
        health_modify = -40;
        stress_modify = 40;
        FindObjectOfType<AudioManager>().Play("door");

        youSure();
    }

    public void buyFood()
    {
        health_modify = -15;
        stress_modify = 10;
        FindObjectOfType<AudioManager>().Play("door");
        youSure();

    }

    public void playGames()
    {
        health_modify = -10;
        stress_modify = -10;
        youSure();

    }

    public void doHomework()
    {
        health_modify = -25;
        stress_modify = 15;
        youSure();

    }

    public void read()
    {
        health_modify = -15;
        stress_modify = -15;
        FindObjectOfType<AudioManager>().Play("pageTurn");
        youSure();
        

    }

    public void study()
    {
        health_modify = -10;
        stress_modify = 5;
        FindObjectOfType<AudioManager>().Play("writing");
        youSure();

    }

    public void sleep()
    {
        health_modify = 100;
        stress_modify = 0;
        FindObjectOfType<AudioManager>().Play("snoring");
        youSure();
    }

    public void applyModifications()
    {
        health.GetComponent<HealthBar>().ModifyHealth(health_modify);
        stress.GetComponent<HealthBar>().ModifyHealth(stress_modify);

    }
}
