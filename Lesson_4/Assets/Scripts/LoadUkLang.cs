using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadUkLang : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(ScenUk);
    }

    private void ScenUk()
    {
        SceneManager.LoadScene("SampleScene UK");
    }
}
