using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.Rendering;

public class OptionsMenu : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterVolumeSlider;
    [SerializeField] Slider musicVolumeSlider;
    [SerializeField] Slider sfxVolumeSlider;

    [Header("Volume Texts")]
    [SerializeField] private TextMeshProUGUI masterVolumeText;
    [SerializeField] private TextMeshProUGUI musicVolumeText;
    [SerializeField] private TextMeshProUGUI sfxVolumeText;

    [Header("Resolution")]
    [SerializeField] TMP_Dropdown resDropdown;
    [SerializeField] Toggle fullscreenToggle;
    Resolution[] resolutions;
    private int savedWidth;
    private int savedHeight;
    private int fullScreen;

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.SetInt("ResWidth", 1920);
        // PlayerPrefs.SetInt("ResHeight", 1080);
        masterVolumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        musicVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxVolumeSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        GetResolutionOptions();
        SetResolutionOnStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float ConvertToDec(float sliderValue)
    {
        return Mathf.Log10(Mathf.Max(sliderValue, 0.0001f)) * 20;
    }

    public void SetMasterVolume()
    {
        audioMixer.SetFloat("MasterVolume", ConvertToDec(masterVolumeSlider.value));
        PlayerPrefs.SetFloat("MasterVolume", masterVolumeSlider.value);
        masterVolumeText.text = (masterVolumeSlider.value).ToString("#0%");
    }

    public void SetMusicVolume()
    {
        audioMixer.SetFloat("MusicVolume", ConvertToDec(musicVolumeSlider.value));
        PlayerPrefs.SetFloat("MusicVolume", musicVolumeSlider.value);
        musicVolumeText.text = (musicVolumeSlider.value).ToString("#0%");
    }

    public void SetSFXVolume()
    {
        audioMixer.SetFloat("SFXVolume", ConvertToDec(sfxVolumeSlider.value));
        PlayerPrefs.SetFloat("SFXVolume", sfxVolumeSlider.value);
        sfxVolumeText.text = (sfxVolumeSlider.value).ToString("#0%");
    }

    void GetResolutionOptions()
    {
        resDropdown.ClearOptions();
        resolutions = Screen.resolutions;
        for (int i = 0; i < resolutions.Length; i++)
        {
            TMP_Dropdown.OptionData newOption;
            newOption = new TMP_Dropdown.OptionData(resolutions[i].width.ToString() + "x" + resolutions[i].height.ToString());
            resDropdown.options.Add(newOption);
        }
    }

    void SetResolutionOnStart()
    {
        savedWidth = PlayerPrefs.GetInt("ResWidth");
        savedHeight = PlayerPrefs.GetInt("ResHeight");
        fullScreen = PlayerPrefs.GetInt("FullscreenToggle");

        if (fullScreen == 1)
        {
            Screen.SetResolution(savedWidth, savedHeight, true);
        }
        else
        {
            Screen.SetResolution(savedWidth, savedHeight, false);
        }
    }

    public void ChooseResolution()
    {
        Screen.SetResolution(resolutions[resDropdown.value].width, resolutions[resDropdown.value].height, fullscreenToggle.isOn);
        PlayerPrefs.SetInt("ResWidth", resolutions[resDropdown.value].width);
        PlayerPrefs.SetInt("ResHeight", resolutions[resDropdown.value].height);
        if (fullscreenToggle.isOn)
        {
            PlayerPrefs.SetInt("FullscreenToggle", 1);
        }
        else
        {
            PlayerPrefs.SetInt("FullscreenToggle", 0);
        }
    }
}
