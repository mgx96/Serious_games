using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicknMove : MonoBehaviour
{
    public GameObject[] buttonTodo;
    public GameObject[] buttonActive;


    public void MoveTask ()
    {
            int i = buttonTodo.Length - 1 ;
            buttonTodo[i].SetActive(false);
            buttonActive[i].SetActive(true);

    }
}
