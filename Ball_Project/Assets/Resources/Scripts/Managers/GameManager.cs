using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : GenericSingleton<GameManager>
{
    public float gameDuration = 60;
    private float gameTime;

    public override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        gameTime = gameDuration;
    }

    private void Update()
    {
        gameTime -= 1 * Time.deltaTime;
        Debug.Log(gameTime);

        if (gameTime <= 0)
        {
            gameTime = gameDuration;
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
