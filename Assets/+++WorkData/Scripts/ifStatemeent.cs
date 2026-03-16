using UnityEngine;

public class ifStatemeent : MonoBehaviour
{
    [SerializeField] public int i1 = 0;
    [SerializeField] public int i2 = 0;
    void Start()
    {
        if (i1 < i2)
        {
            Debug.Log("i1 is smaller than i2");
        }
        else if (i1 > i2)
        {
            Debug.Log("i1 is larger than i2");
        }
        else
        {
            Debug.Log("i1 and i2 are equal");
        }
    }
}
