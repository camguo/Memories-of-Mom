using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] Vector3 homePosition = Vector3.zero;
    public Vector2 moveVal;
    [SerializeField] public float moveSpeed = 3f;

    void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }

    void OnStartRun()
    {
        moveSpeed = 5f;
    }

    void OnEndRun()
    {
        moveSpeed = 3f;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = homePosition;
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
        
        transform.Translate(new Vector3(moveVal.x, moveVal.y, 0) * moveSpeed * Time.deltaTime);
    }

    // public void PlayAudio()
    // {
    //     GetComponent<AudioSource>().Play();
    // }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Ginger>() != null || other.GetComponent<Pork>() != null || other.GetComponent<Rice>() != null || other.GetComponent<Seasoning>() != null)
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
    }
}