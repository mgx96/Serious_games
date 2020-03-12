using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicknMove : MonoBehaviour
{
    public GameObject buttonTodo;
    public GameObject buttonActive;
    


    public void MoveTask ()
    {
        buttonTodo.SetActive(false);
        buttonActive.SetActive(true);
    }

    public void MoveTaskBack ()
    {
        buttonTodo.SetActive(true);
        buttonActive.SetActive(false);
    }
}
