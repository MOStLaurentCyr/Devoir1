using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveVertical();
        MoveHorizontal();
    }

    private void MoveVertical()
    {
        float move = Input.GetAxis("Vertical") * 10;
        move *= Time.deltaTime;

        transform.Translate(0, 0, move);
    }

    private void MoveHorizontal()
    {
        float rotation = Input.GetAxis("Horizontal") * 100;
        rotation *= Time.deltaTime;

        transform.Rotate(0, rotation, 0);
    }
}
