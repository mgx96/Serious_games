using UnityEngine;

public class interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform player;
    bool interacting = false;
    bool pressed = false;
    public GameObject window;
    public GameObject press;
    

    public virtual void Interact()
    {

        //ACTUAL INTERACTION
        Debug.Log("interact");

    }

    #region VisualFeedback
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    #endregion VisualFeedback

    public void Update()
    {

        float distance = Vector3.Distance(player.position, transform.position);

        if ((distance <= radius) && (interacting == false))
        {
            Interact();
            interacting = true;
        }

        if (distance > radius) 
        {
            interacting = false;    
            window.SetActive(false);
        }

        if (interacting)
        {

            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("you pressed something");
                pressed = true;
                window.SetActive(true);
                press.SetActive(false);
            }
        }
    }

    public bool getInteracting()
    {
        return interacting;
    }
}
