using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 720f; // Швидкість повороту в градусах на секунду
    public Transform spriteTransform; 

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f);

        // 1. Рух (незалежний від повороту)
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // 2. Плавний поворот
        if (movement.sqrMagnitude > 0.01f) 
        {
            // Вираховуємо цільовий кут
            float targetAngle = Mathf.Atan2(moveY, moveX) * Mathf.Rad2Deg;
            
            // Створюємо Quaternion (цільовий поворот)
            Quaternion targetRotation = Quaternion.Euler(0, 0, targetAngle+30);
            
            // Плавно змінюємо поточний поворот на цільовий
            spriteTransform.rotation = Quaternion.RotateTowards(
                spriteTransform.rotation, 
                targetRotation, 
                rotationSpeed * Time.deltaTime
            );
        }
    }
}