using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class settingsMenuScript : MonoBehaviour
{

    public AudioMixer mainMixer;

   public void setQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }

    public void setFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }
}
