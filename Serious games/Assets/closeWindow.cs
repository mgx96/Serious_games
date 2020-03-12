using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeWindow : MonoBehaviour
{
    public GameObject window;
    public GameObject confirm;
    //SOMETHING TO ENABLE MOVEMENT;

    public void youSure ()
    {
        confirm.SetActive(true);
    }

    public void closeAll ()
    {
        window.SetActive(false);
        confirm.SetActive(false);
        //SOMETHING THAT ENABLES MOVEMENT, EVEN WITHIN INTERACTION RADIUS;
    }

    public void taskList ()
    {
        confirm.SetActive(false);
    }
}
