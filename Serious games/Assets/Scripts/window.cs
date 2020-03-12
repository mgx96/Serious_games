using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window : MonoBehaviour
{
    public GameObject confirmWindow;
    public GameObject[] buttons;

    bool window_close;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void youSure()
    {
        confirmWindow.SetActive(true);

    }

    public void closeAll()
    {
        this.gameObject.SetActive(false);
        confirmWindow.SetActive(false);
        window_close = true;
        //SOMETHING THAT ENABLES MOVEMENT, EVEN WITHIN INTERACTION RADIUS;
    }

    public void taskList()
    {
        confirmWindow.SetActive(false);
    }

    public bool getWindowClose()
    {
        return window_close;
    }
    public void setWindowClose(bool close)
    {
        window_close = close;
    }


}
