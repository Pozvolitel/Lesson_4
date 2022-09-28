using UnityEngine;
using UnityEngine.UI;

public class RegisterNew : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(isGood);
    }

    private void isGood()
    {
        Debug.Log("Congratulations, you have successfully registered");
    }
}
