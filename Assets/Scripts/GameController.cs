using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //platform gameobject
    [Header("Platform Object")]
    public GameObject platform;
    //default position for platform
    float pos = 0;
    //GameOver Canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    //game over func
    public void GameOver()
    {
        //game over canvas active
        gameOverCanvas.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        //integer i equals 1000
        for (int i = 0; i < 1000; i++)
        {
            //execute spawn platforms
            SpawnPlatforms();
        }
    }

    //spawn platforms function
    void SpawnPlatforms()
    {
        //spawn platforms randomly on x axis and place them on the y axis every 2.5
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 3.5f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
