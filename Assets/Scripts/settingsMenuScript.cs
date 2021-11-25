using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsMenuScript : MonoBehaviour
{
   public void setQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
}
