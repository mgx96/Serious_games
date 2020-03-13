using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject[] interactables;
    private GameObject currentInteractable;

    private GameObject currentWindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < interactables.Length;  i++)
        {
            if(interactables[i].GetComponent<interactable>().getInteracting())
            {
                currentInteractable = interactables[i];
                currentWindow = currentInteractable.GetComponent<interactable>().window;
            }
        }
        

    }


}
