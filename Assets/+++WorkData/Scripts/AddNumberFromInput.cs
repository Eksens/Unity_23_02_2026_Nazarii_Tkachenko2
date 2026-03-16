using TMPro;
using UnityEngine;

public class AddNumberFromInput : MonoBehaviour
{
    [SerializeField] public TMP_InputField inputField;
    [SerializeField] public TMP_InputField inputField2;
    [SerializeField] public TextMeshProUGUI ResultField;
    public void AddNumber()
    {
        int i1 = int.Parse(inputField.text);
        int i2 = int.Parse(inputField2.text);
        string result;
        if (i1 < i2)
        {
            result = "First number is smaller than second number";
        }
        else if (i1 > i2)
        {
            result = "First number is larger than second number";
        }
        else
        {
            result = "First and second numbers are equal";
        }
        ResultField.text = result;
    }
}
