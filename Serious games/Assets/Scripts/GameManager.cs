﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject player_camera;
    public GameObject[] interactables;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < interactables.Length; i++)
        {
            if (interactables[i].GetComponent<interactable>().getInteracting())
            {
                player_camera.GetComponent<PlayerLook>().UnlockCursor();
            }
        }
    }
}
