using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRotation : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}
