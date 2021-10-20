﻿using UnityEngine;

public static class IInput
{
    private static bool IsKeyDown = false;
    private static float LastTime;
    public static bool GetKeyDown(KeyCode keyCode, float delay = 0.25f)
    {
        if (Input.GetKeyDown(keyCode))
        {
            LastTime = Time.realtimeSinceStartup + delay;
            if (!IsKeyDown)
            {
                IsKeyDown = true;
                return false;
            }
            
            return true;
        }
        if (Time.realtimeSinceStartup > LastTime)
        {
            IsKeyDown = false;
            return false;
        }
        return false;
    }
}