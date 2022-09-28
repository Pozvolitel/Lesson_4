using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(ResetS);
    }

    private void ResetS()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
