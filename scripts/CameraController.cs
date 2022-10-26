using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour   //script to have camera follow player
{
    [SerializeField] private Transform player;

    // Update is called once per frame
    private void Update()
    {                                               //3rd arg pulls from Transform Z position (should be -10)
       transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
