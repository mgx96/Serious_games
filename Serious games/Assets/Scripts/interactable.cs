using UnityEngine;

public class interactable : MonoBehaviour
{
    public float radius = 3f;
    Transform player;
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

    public void Update ()
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
