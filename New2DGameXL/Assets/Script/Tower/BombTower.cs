using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTower : CharacterBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health = health - 1;
            Destroy(collision.gameObject);
        }
    }
}
