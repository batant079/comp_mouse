using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
   public void changevol()
    {
        AudioListener.volume = VolumeSlider.value;
    }
}
