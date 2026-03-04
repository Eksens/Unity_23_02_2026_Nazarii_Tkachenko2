using UnityEngine;

public class Price : MonoBehaviour
{
    [SerializeField]private int price = 3;
    [SerializeField]private int count = 10;
    [SerializeField]private string discount = "50%";
    
    void Start()
    {
        float discountFloat = float.Parse(discount.Replace("%", "")) / 100f;
        float result = price*count*discountFloat;
        Debug.Log("Price: " + price +"$");
        Debug.Log("Count: " + count);
        Debug.Log("Discount: " + discount);
        Debug.Log("Total price: " + result +"$");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
