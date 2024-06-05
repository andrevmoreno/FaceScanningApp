using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("Button clicked!");
        // Add your functionality here
    }
}
