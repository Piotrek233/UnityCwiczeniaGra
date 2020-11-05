using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstPunkty : MonoBehaviour
{

    public Text punktytekst;
    // Update is called once per frame
    void Update()
    {
        punktytekst.text = "Punkty: " + FindObjectOfType<Punkty>().wynik.ToString();
    }
}
