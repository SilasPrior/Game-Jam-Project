using UnityEngine;
using UnityEngine.Audio;
using System.Collections.Generic;
using TMPro;

public class SettingsController : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown resolutionDropdown;

    public AudioMixer audioMixer;
    
    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> resOptions = new List<string>();

        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            resOptions.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(resOptions);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetRes(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolMaster(float volume)
    {
        audioMixer.SetFloat("MasterVol", Mathf.Log10(volume) * 20);
    }

    public void SetVolMusic(float volume)
    {
        audioMixer.SetFloat("MusicVol", Mathf.Log10(volume) * 20);
    }

    public void SetVolSFX(float volume)
    {
        audioMixer.SetFloat("SFXVol", Mathf.Log10(volume) * 20);
    }

    public void SetVolDialogue(float volume)
    {
        audioMixer.SetFloat("DialogueVol", Mathf.Log10(volume) * 20);
    }
}
