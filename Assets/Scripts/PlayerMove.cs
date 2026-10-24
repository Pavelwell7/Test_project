using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Настройка движения")]
    public float speed = 5.0f;
    void Start()
    {
        Debug.Log("Скрипт движения запущен");
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(moveX, moveY).normalized;

        transform.Translate(direction * speed * Time.deltaTime);

    }
}
