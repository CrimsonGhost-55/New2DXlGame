using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float enemyTimer = 0f;
    public float spawnInterval = 1f;

    public int enemyCounter = 0;

    public Vector2 xBounds;
    public Vector2 yBounds;

    public GameObject enemy;

    public int spawnLimit = 20;
    public static GameManager Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyTimer += Time.deltaTime;
        Vector3 targetPos = new Vector3(Random.Range(xBounds.x, xBounds.y), Random.Range(yBounds.y, yBounds.y), 0);

        if (enemyTimer >= spawnInterval && enemyCounter < spawnLimit)
        {
            enemyTimer = 0;
            Instantiate(enemy, targetPos, Quaternion.identity);
            enemyCounter++;
        }
    }
}
