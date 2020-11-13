using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchKamery : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sledzGracza;
    public Vector3 pozycjaKamery;

    // Update is called once per frame
    void Update()
    {
        transform.position = sledzGracza.transform.position + pozycjaKamery;
    }
}
