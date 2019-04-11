using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;

    public GameObject[] health;

    public GameObject gameOver;

    public Transform firePoint;

    [HideInInspector]
    public int i = 0;

    [HideInInspector]
    public int score = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && i < 3)
        {
            SoundManagerScript.PlaySound("Fire");
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }

    public void ReduceHealthOnMiss()
    {
        health[i].SetActive(false);
        i++;
    }

    public void EndGame()
    {
        gameOver.SetActive(true);
        //Invoke("LoadNewGame", 3f);
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene("Game");
    }
}
