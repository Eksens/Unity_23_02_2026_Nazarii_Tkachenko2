using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 720f; 
    public Transform spriteTransform; 

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f);
        
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        if (movement.sqrMagnitude > 0.01f) 
        {
            float targetAngle = Mathf.Atan2(moveY, moveX) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0, 0, targetAngle+30);
            spriteTransform.rotation = Quaternion.RotateTowards(
                spriteTransform.rotation, 
                targetRotation, 
                rotationSpeed * Time.deltaTime
            );
        }
    }
}