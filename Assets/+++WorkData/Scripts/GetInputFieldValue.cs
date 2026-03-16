using UnityEngine;
using TMPro;

public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI inputField;
    public void GetNumber()
    {
        Debug.Log(inputField.text);
    }
}
