using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement; public float speed;
    public float maxHeight; public float minHeight;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            targetPos = new Vector2(transform.position.x + Yincrement, transform.position.y);
            transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            targetPos = new Vector2(transform.position.x - Yincrement, transform.position.y);
            transform.position = targetPos;

        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;

        }
    }
}
