using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class Settings : MonoBehaviour
{
    
    public AudioMixer audioMixer;
    public TMP_Dropdown resDropdown;

    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        resDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && 
               resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }

        }

        resDropdown.AddOptions(options);
        resDropdown.value = currentResolutionIndex;
        resDropdown.RefreshShownValue();

    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreen(bool isFullscren)
    {
        Screen.fullScreen = isFullscren;
    }

}
