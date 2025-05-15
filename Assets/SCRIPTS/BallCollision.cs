using TMPro;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private int score = 0;
    [SerializeField]
    private TMP_Text scoreTxt;
    [SerializeField]
    private int scoreToGet, initialTime;
    [SerializeField]
    private GameObject victoryUI, GameUI;
    [SerializeField]
    private TMP_Text timeDoneText;
    [SerializeField]
    private FloatReference timeLeft;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            score++;
            scoreTxt.text = score.ToString();
        }

        if(score == scoreToGet)
        {
            victoryUI.SetActive(true);
            GameUI.SetActive(false);
            
            Time.timeScale = 0f;

            float scoreTime = initialTime - timeLeft.nb;
            int minutes = Mathf.FloorToInt(scoreTime / 60);
            int seconds = Mathf.FloorToInt(scoreTime % 60);
            timeDoneText.text = "In only " + minutes + " minute(s) and " + seconds+" seconds";
            //[TODO] Changer pour un String builder


        }
    }
}
