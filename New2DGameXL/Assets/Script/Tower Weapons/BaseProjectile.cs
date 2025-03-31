using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : MonoBehaviour
{

    public float speed = 0.5f;
    public GameObject thisObject;
    public float xDir = 0f;
    public float yDir = 0f;

    public float lifeTime = 3f;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        xDir = Random.Range(-1f, 1f);
        yDir = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        thisObject.transform.position += new Vector3(xDir, yDir, 0) * speed;
        if (timer >= lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
