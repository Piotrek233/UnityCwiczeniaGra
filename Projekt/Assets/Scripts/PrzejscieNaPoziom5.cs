﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrzejscieNaPoziom5 : MonoBehaviour
{
    void OnCollisionEnter(Collision gameObjectInformaction)
    {
        if (gameObjectInformaction.gameObject.name == "Gracz")
        {
            Debug.Log("Collision Detected");
            SceneManager.LoadScene("poziom5");
        }
    }
}
