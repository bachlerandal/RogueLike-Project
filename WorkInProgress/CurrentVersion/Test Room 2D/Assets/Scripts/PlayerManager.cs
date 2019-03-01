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
    private int gridArrayX;
    private int gridArrayY;

    public BoardManager boardScript;

    private void Start()
    {

        posX = 0;
        posY = 0;

        gridArrayX = 1;
        gridArrayY = 1;
    }

    private void Update()
    {

        //Following IF statements determine if WASD are pressed. If so, they move 1 value of moveDistance in the correct direction based on WASD keys

        //Forward (UP) movement
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(boardScript.getTile(gridArrayX, gridArrayY + 1));
            if (boardScript.getTile(gridArrayX, gridArrayY + 1) == false)
            {
                y = moveDistance;
                x = 0;
                transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
                posY = posY + moveDistance;
                gridArrayY = gridArrayY + moveDistance;
                
            }

        }
        //Back(Down) movement
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(boardScript.getTile(gridArrayX, gridArrayY - 1));
            if (boardScript.getTile(gridArrayX, gridArrayY - 1) == false)
            {
                y = moveDistance;
                x = 0;
                transform.position = new Vector2(transform.position.x + x, transform.position.y - y);
                posY = posY - moveDistance;
                gridArrayY = gridArrayY - moveDistance;
            }

        }
        //Left movement
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(boardScript.getTile(gridArrayX - 1, gridArrayY));
            if (boardScript.getTile(gridArrayX - 1, gridArrayY) == false)
            {
                y = 0;
                x = moveDistance;
                transform.position = new Vector2(transform.position.x - x, transform.position.y + y);
                posX = posX - moveDistance;
                gridArrayX = gridArrayX - moveDistance;
            }

        }
        //Right movement
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(boardScript.getTile(gridArrayX + 1, gridArrayY));
            if (boardScript.getTile(gridArrayX + 1, gridArrayY) == false)
            {
                y = 0;
                x = moveDistance;
                transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
                posX = posX + moveDistance;
                gridArrayX = gridArrayX + moveDistance;
            }

        }

        
    }
   
}
