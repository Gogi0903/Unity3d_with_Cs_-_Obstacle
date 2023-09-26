using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{   
    // a [SerializeField] teszi elérhetővé a változót a unity inspectorban
    [SerializeField] float moveSpeed = 10f;  
    // Start is called before the first frame update
    void Start()
    {   
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {   
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("For moving, use W, S, A, D or arrows");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        // az Input. paranccsal férünk hozzá a unity Input Managerhez. a Time.deltaTime framerate-függetlenné teszi
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);   
    }
}
