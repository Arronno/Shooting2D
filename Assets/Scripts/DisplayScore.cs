using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void Update()
    { 
        scoreText.text = "SCORE\n" + FindObjectOfType<Shooter>().score.ToString();
    }
}
