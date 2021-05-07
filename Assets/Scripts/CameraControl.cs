using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Vector3 offset;
    private GameObject player;
      
    void Update () 
    {
        player = GameObject.Find("Player(Clone)");
        transform.position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }

}
