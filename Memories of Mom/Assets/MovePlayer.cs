using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    public Vector2 moveVal;
    [SerializeField] public float moveSpeed = 1f;

    void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }

    void OnStartRun(InputValue value)
    {
        moveSpeed = 5f;
    }

    void OnEndRun(InputValue value)
    {
        moveSpeed = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if ((moveVal.x > 0 && moveVal.y > 0) /*UpRight*/
        // || (moveVal.x < 0 && moveVal.y > 0) /*UpLeft*/
        // || (moveVal.x > 0 && moveVal.y < 0) /*DownRight*/
        // || (moveVal.x < 0 && moveVal.y < 0) /*DownLeft*/)
        // {
        //     transform.Translate(new Vector3(moveVal.x, moveVal.y/2, 0) * moveSpeed * Time.deltaTime);
        // }
        
        transform.Translate(new Vector3(moveVal.x, moveVal.y/2, 0) * moveSpeed * Time.deltaTime);
    }
}
