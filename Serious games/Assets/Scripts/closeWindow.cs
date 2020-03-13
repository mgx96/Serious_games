using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeWindow : MonoBehaviour
{
    public GameObject window;
    public GameObject confirm;
    //SOMETHING TO ENABLE MOVEMENT;

    bool window_close;
    public void youSure ()
    {
        confirm.SetActive(true);

    }

    public void closeAll ()
    {
        window.SetActive(false);
        confirm.SetActive(false);

        window_close = true;
        //SOMETHING THAT ENABLES MOVEMENT, EVEN WITHIN INTERACTION RADIUS;
    }

    public void taskList ()
    {
        confirm.SetActive(false);
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
