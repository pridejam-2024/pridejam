using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerMoveSpeed = 20.0f;
    [SerializeField]
    private GameObject parent;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Player");
        playerTransform = parent.transform;
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();
        HandlePlayerAttacks();
        HandlePlayerInteraction();
        HandleChangeCurrentAbility();
    }

    void HandlePlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            parent.transform.position += Vector3.up * playerMoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            parent.transform.position += Vector3.left * playerMoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            parent.transform.position += Vector3.down * playerMoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            parent.transform.position += Vector3.right * playerMoveSpeed * Time.deltaTime;
        }
    }

    void HandlePlayerAttacks()
    {
        //left click
        if (Input.GetMouseButton(0))
        {

        }
        //right click
        if (Input.GetMouseButton(1))
        {

        }
    }

    void HandlePlayerInteraction()
    {
        //check if the object is an interactable
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }

    void HandleChangeCurrentAbility()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

        }

        //handle scrollwheel?

    }
}
