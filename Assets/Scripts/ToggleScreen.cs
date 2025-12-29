using UnityEngine;

public class ToggleScreen : MonoBehaviour
{
    public void ChangeScreenMode()
    {
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        
        if (Screen.fullScreenMode == FullScreenMode.FullScreenWindow || Screen.fullScreenMode == FullScreenMode.ExclusiveFullScreen)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
        else if (Screen.fullScreenMode == FullScreenMode.Windowed)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        }
    }
}
