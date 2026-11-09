using UnityEngine;

public class SettingsController : MonoBehaviour
{
    bool FullScreen = false;
    int[] Res = new int[2] {1920, 1080};

    void Start()
    {

        Screen.SetResolution(Res[0], Res[1], FullScreen);
    }

    public void SetFullScreen()
    {
        if (FullScreen)
        {
            FullScreen = false;
        }
        else
        {
            FullScreen = true;
        }

        Screen.SetResolution(Res[0], Res[1], FullScreen);
    }

    public void SetRes(int width)
    {
        Res[0] = width;
        //Res[1] = hight;

        Screen.SetResolution(Res[0], Res[1], FullScreen);
    }
}
