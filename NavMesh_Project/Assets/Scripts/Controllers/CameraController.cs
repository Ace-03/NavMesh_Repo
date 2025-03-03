using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ship;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(ship.transform.position.x, 0, ship.transform.position.z);
    }
}
