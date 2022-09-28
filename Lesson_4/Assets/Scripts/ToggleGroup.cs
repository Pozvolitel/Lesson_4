using UnityEngine;
using UnityEngine.UI;

public class ToggleGroup : MonoBehaviour
{
    [SerializeField] private GameObject _image;
    private Toggle _toggle;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();

        
    }

    private void Update()
    {
       if (_toggle.isOn)
        {
            _image.SetActive(true);
        } 
       else
        {
            _image.SetActive(false);
        }
    }

   
}
