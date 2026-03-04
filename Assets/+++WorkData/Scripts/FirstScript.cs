using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(message:"The game is started");
    }

    // Update is called once per frame
    public int x = 0;
    void Update()
    {
        Debug.Log(message:"Update: "+ x);
        x += 1;
    }
    
    //<>/\{}[]||  
}
