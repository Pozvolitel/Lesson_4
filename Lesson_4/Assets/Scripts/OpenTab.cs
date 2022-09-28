using UnityEngine;
using UnityEngine.UI;

public class OpenTab : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _parentObj;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Open);
    }

    private void Open()
    {
        _parentObj.SetActive(true);
    }
}
