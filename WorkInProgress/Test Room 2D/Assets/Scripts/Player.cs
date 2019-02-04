using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void Move()
    {
        transform.Translate(Vector2.right);
    }
}
