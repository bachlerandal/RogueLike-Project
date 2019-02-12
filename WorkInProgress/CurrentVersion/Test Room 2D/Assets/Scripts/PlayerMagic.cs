using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{
    Animation anim;
    public GameObject fireball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            shoot();
        }
    }

    private void shoot()
    {
        //ewanim.Play("shoot");
        Instantiate(fireball, transform.position, transform.rotation);
    }
}
