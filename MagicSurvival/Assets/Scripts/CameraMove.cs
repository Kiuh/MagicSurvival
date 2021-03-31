using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    float time = 0.04f;
    [SerializeField]
    float poz_z = -10;
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Player.transform.position, time);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, poz_z);
    }
}
