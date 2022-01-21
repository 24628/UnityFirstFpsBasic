using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmemyAi : MonoBehaviour
{

    public GameObject player;
    public CharacterController controller;
    
    private float speed = 6f;
    private float distanceBetweenPlayer = 5f;
    void Update()
    {
        Debug.Log(player.transform.localPosition);
        Debug.Log(transform.localPosition);
        

        var offset = player.transform.position - transform.position;
        if(offset.magnitude > distanceBetweenPlayer) {
            offset = offset.normalized * speed;
            controller.Move(offset * Time.deltaTime);
        }
    }
}
