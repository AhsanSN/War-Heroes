using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slider : MonoBehaviour
{
    Slider slider;
    public GameObject AudioManager;

    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
    }
}
