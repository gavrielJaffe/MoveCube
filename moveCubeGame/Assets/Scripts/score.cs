using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;


public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // // player.position.z;
        // // Debug.Log('player.position.z:', player.position.z);
        // Debug.Log( "player.position.z:" + player.position.z);
        
        scoreText.text = player.position.z.ToString("0");
        
    }
}
