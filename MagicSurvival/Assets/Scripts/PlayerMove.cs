using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerParameters parameters;
    void Awake()
    {
        parameters = this.GetComponent<PlayerParameters>();
    }
    private void FixedUpdate()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        this.transform.position = Vector3.Lerp(
            this.transform.position,
            this.transform.position + new Vector3(moveInput.normalized.x, moveInput.normalized.y, 0),
            parameters.Speed);
    }
}
