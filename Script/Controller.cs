using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speedMove;
    public float smoothMove;

    public bool mouseControll;
    
    private Vector2 vectorVelocity = Vector2.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controll();
    }
    void Controll()
    {
        if (mouseControll == true)
        {
            MouseControll();
        }
        else
        {
            KeyBoardControll();
        }
    }
    void KeyBoardControll()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 diraction = new Vector2(horizontal * speedMove * Time.deltaTime + transform.position.x, 0f);

        transform.position = Vector2.SmoothDamp(transform.position, diraction, ref vectorVelocity, smoothMove);
    }
    void MouseControll()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 diraction = new Vector2(mousePos.x, transform.position.y);

        transform.position = Vector2.MoveTowards(transform.position, diraction, speedMove * Time.deltaTime * 0.2f);
    }
}

