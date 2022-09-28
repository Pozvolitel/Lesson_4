using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenFacebook : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(GoGoogle);
    }

    private void GoGoogle()
    {
        System.Diagnostics.Process.Start("https://m.facebook.com/login/");
    }
}
