using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    private AudioSource _audio;
    private Slider _slider;

    private void Start()
    {
        _audio = FindObjectOfType<AudioSource>();
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        _audio.volume = _slider.value;
    }
}
