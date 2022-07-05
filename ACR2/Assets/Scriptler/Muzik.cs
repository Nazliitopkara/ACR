using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzik : MonoBehaviour
{
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
