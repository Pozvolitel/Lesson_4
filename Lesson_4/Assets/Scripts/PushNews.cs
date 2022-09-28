using UnityEngine;
using UnityEngine.UI;

public class PushNews : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;    

    private void Awake()
    {
        _toggle.onValueChanged.AddListener(OnSwitch);
        if (_toggle.isOn)
        {
            OnSwitch(true);
        }
    }

    private void OnSwitch(bool on)
    {
        if (on)
        {
            Debug.Log("Congratulations, you have successfully subscribed to Messages");
        }
        else
        {
            Debug.Log("Messages disabled");
        }
    }

    private void OnDestroy()
    {
        _toggle.onValueChanged.RemoveListener(OnSwitch);
    }
}
