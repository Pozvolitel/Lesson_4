using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] private RectTransform _uiHander;
    private Toggle _toggle;
    private Vector2 _handlerPos;
    [SerializeField] private GameObject _textON;
    [SerializeField] private GameObject _textOFF;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
        _handlerPos = _uiHander.anchoredPosition;
        _toggle.onValueChanged.AddListener(OnSwitch);

        if(_toggle.isOn)
        {
            OnSwitch(true);
        }
    }

    private void OnSwitch(bool on)
    {
        _uiHander.anchoredPosition = on ? _handlerPos * -1 : _handlerPos;
        if(on)
        {
            _textON.SetActive(true);
            _textOFF.SetActive(false);
        }
        else
        {
            _textOFF.SetActive(true);
            _textON.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        _toggle.onValueChanged.RemoveListener(OnSwitch);
    }
}
