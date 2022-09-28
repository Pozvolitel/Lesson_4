using UnityEngine;
using UnityEngine.UI;

public class CloseTab : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _parentObj;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Close);
    }

    private void Close()
    {
        _parentObj.SetActive(false);
    }
}
