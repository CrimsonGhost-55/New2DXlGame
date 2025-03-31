using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTower : CharacterBase
{
    public GameObject projectile;

    public float spawnTimer = 0f;
    public float spawnInterval = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            spawnTimer = 0f;
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("coliding with enemy");
            health = health - 1;
            Destroy(collision.gameObject);
        }
    }
}
