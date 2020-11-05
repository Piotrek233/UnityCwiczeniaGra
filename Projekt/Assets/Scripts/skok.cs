using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skok : MonoBehaviour
{
    public float silaSkoku = 5.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // trzeba jakos to zablokowac bo narazie postac nam lata po calej mapie jak trzyma spacje xD
        if(Input.GetKey(KeyCode.Space))
        {
            if (rb.velocity.y == 0)
            {
                rb.AddForce(Vector3.up * silaSkoku, ForceMode.Impulse);
            }
        }
    }
}
