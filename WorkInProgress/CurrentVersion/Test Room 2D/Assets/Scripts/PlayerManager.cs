using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // variables for movement in the 2D plane
    // x is X axis
    private int x;
    //y is Y axis
    private int y;
    //moveDistance is the variable that determines actual distance moved per keyDown
    private int moveDistance = 1;
    //Current player position
    private int posX;
    private int posY;

    private BoardManager boardScript;

    private void Awake()
    {
        boardScript = GetComponent<BoardManager>();
    }

    private void Start()
    {

        posX = 0;
        posY = 0;
    }

    private void Update()
    {

        //Following IF statements determine if WASD are pressed. If so, they move 1 value of moveDistance in the correct direction based on WASD keys

        //Forward (UP) movement
        if (Input.GetKeyDown(KeyCode.W))
        {
            y = moveDistance;

            x = 0;

            transform.position = new Vector2(transform.position.x + x, transform.position.y + y);

            posY = posY + moveDistance;
            
        }
        //Back(Down) movement
        else if (Input.GetKeyDown(KeyCode.S))
        {
            y = -moveDistance;
            x = 0;
            transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
            posY = posY - moveDistance;
        }
        //Left movement
        else if (Input.GetKeyDown(KeyCode.A))
        {
            y = 0;
            x = -moveDistance;
            transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
            posX = posX - moveDistance;
        }
        //Right movement
        else if(Input.GetKeyDown(KeyCode.D))
        {
            y = 0;
            x = moveDistance;
            transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
            posX = posX + moveDistance;
        }

        
    }
   
}
