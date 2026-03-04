using UnityEngine;

public class ThirdScript : MonoBehaviour
{
    [SerializeField]private int i1 = 3;
    [SerializeField]private int i2 = 10;
    
    void Start()
    {
        int i3 = i1 - i2;
        i1 -= i3; //i1 = i1 - i3
        i2 += i3;
        Debug.Log("i1 = " + i1);
        Debug.Log("i2 = " + i2);
        Debug.Log("i1 + i2 = " + (i1 + i2));
    }
}
