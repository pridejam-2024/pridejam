using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    private GameObject Player;
    private bool canPickUp = false;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickUp && Input.GetKeyUp(KeyCode.E))
        {
            Pickup();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            canPickUp = true;
            DisplayPickupUI();
            Debug.Log("Player entered pickup range.");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            canPickUp = false;
            HidePickupUI();
            Debug.Log("Player exited pickup range.");
        }
    }

    void DisplayPickupUI()
    {
        Debug.Log("Displaying pickup UI.");
        // Code to display the pickup UI goes here
    }

    void HidePickupUI()
    {
        Debug.Log("Hiding pickup UI.");
        // Code to hide the pickup UI goes here
    }

    void Pickup()
    {
        Debug.Log("Item picked up.");
        // Code to handle the pickup action goes here
        // For example, adding the item to the player's inventory

        // After picking up, you might want to disable the item or destroy it
        gameObject.SetActive(false);
    }
}
