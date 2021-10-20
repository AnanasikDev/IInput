using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    IInput InputController1;
    IInput InputController2;
    private void Start()
    {
        InputController1 = new IInput();
        InputController2 = new IInput();
    }
    void Update()
    {
        if (InputController1.GetKeyDown(KeyCode.Space, 3))
        {
            print("TRIPPLEKILL");
        }

        if (InputController2.GetKeyDown(KeyCode.W, 2))
        {
            print("DOUBLEKILL");
        }
    }
}
