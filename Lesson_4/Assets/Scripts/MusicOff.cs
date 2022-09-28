using UnityEngine;
using UnityEngine.UI;

public class MusicOff : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    private AudioSource _audio;

    private void Awake()
    {      
        _audio = FindObjectOfType<AudioSource>();
        _toggle.onValueChanged.AddListener(OnSwitch);
        if (_toggle.isOn)
        {
            OnSwitch(true);
        }
    }

    private void OnSwitch(bool on)
    {
        if(on)
        {
            _audio.enabled = true;
        }
        else
        {
            _audio.enabled = false;
        }
    }

    private void OnDestroy()
    {
        _toggle.onValueChanged.RemoveListener(OnSwitch);
    }
}
