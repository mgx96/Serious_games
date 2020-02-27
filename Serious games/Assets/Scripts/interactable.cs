using UnityEngine;

public class interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform player;
   // bool isFocus = false;

    public virtual void Interact()
    {
        //here is the actual interaction, just call the method
        Debug.Log("interact");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    void Update ()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance <= radius)
        {
            Interact();
        }

    }


    /* FOCUS MECHANIC
     * 
    public void Focused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;

    }
    public void Defocused ()
    {
        isFocus = false;
        player = null;
    }*/
}
