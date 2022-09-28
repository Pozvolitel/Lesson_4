using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadEuLang : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(ScenEu);
    }

    private void ScenEu()
    {
        SceneManager.LoadScene("SampleScene EU");
    }
}
