using UnityEngine;

public class IInput
{
    private int ClicksCount = 1;
    private float LastTime;
    public bool GetKeyDown(KeyCode keyCode, int times = 2, float delay = 0.25f, bool doubleClicksOnly = true)
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
