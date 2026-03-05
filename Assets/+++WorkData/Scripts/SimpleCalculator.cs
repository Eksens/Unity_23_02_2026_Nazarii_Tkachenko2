using UnityEngine;
using TMPro;

public class SimpleCalculator : MonoBehaviour
{
    public TextMeshProUGUI myTextObject;
    public SimpleMovement movementScript;
    
    [SerializeField]private int Number1;
    public float charSpeed;
    
    public void calculate(int value)
    {
        Number1 = int.Parse(myTextObject.text);
        Number1 += value;
        myTextObject.text = Number1.ToString();
        movementScript.speed = Number1;
    }
}
