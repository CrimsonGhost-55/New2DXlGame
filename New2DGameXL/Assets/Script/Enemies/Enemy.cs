using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharacterBase
{
    public float speed;
    public float xSpeed;
    public float ySpeed;
    public float xDir;
    public float yDir;
    public float reverseTime = 0f;
    public float reverseInterval = 1f;

    public GameObject thisObject;
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(xSpeed, ySpeed);
        xDir = Random.Range(-1f, 1f);
        yDir = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
        manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += new Vector3(xDir, yDir, 0) * speed;
        reverseTime += Time.deltaTime;
        if (reverseTime >= reverseInterval)
        {
            reverseTime = 0f;
            xDir = xDir * -1;
            yDir = yDir * -1;
        }

        if (health <= 0)
        {
            manager.enemyCounter--;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bombs")
        {
            health = health - 5;
            Destroy(other.gameObject);
        }
    }
}
