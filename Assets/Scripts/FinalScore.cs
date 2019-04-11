using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{ 
    public Text finalScoreText;

    public GameObject scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        finalScoreText.text = "YOUR SCORE\n" + FindObjectOfType<Shooter>().score;
        scoreBoard.SetActive(false);
    }
}
