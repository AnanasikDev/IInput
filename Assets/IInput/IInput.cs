using UnityEngine;

public static class IInput
{
    private static int ClicksCount = 1;
    private static float LastTime;
    public static bool GetKeyDown(KeyCode keyCode, int times = 2, float delay = 0.25f, bool doubleClicksOnly = true)
    {
        if (Input.GetKeyDown(keyCode))
        {
            LastTime = Time.realtimeSinceStartup + delay;
            if (ClicksCount < times)
            {
                ClicksCount++;
                return false;
            }
            if (doubleClicksOnly) ClicksCount = 1;
            return true;
        }
        if (Time.realtimeSinceStartup > LastTime)
        {
            ClicksCount = 1;
            return false;
        }
        return false;
    }
}
