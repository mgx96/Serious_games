using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject health;
    public GameObject stress;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToSchool()
    {
        this.gameObject.GetComponent<interactable>().window.GetComponent<closeWindow>().youSure();
        health.GetComponent<HealthBar>().ModifyHealth(-50);
        stress.GetComponent<HealthBar>().ModifyHealth(30);
    }

    public void goToWork()
    {
        health.GetComponent<HealthBar>().ModifyHealth(-40);
        stress.GetComponent<HealthBar>().ModifyHealth(40);
        this.gameObject.GetComponent<interactable>().window.GetComponent<closeWindow>().youSure();
    }

    public void buyFood()
    {
        health.GetComponent<HealthBar>().ModifyHealth(-15);
        stress.GetComponent<HealthBar>().ModifyHealth(10);
        this.gameObject.GetComponent<interactable>().window.GetComponent<closeWindow>().youSure();

    }

}
