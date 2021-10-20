using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Update()
    {
        if (IInput.GetKeyDown(KeyCode.Space))
        {
            print("DOUBLEKILL");
        }
    }
}
