using System.Text;
using TMPro;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
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
    [SerializeField]
    private IntReference score;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            score.nb++;
            scoreTxt.text = score.nb.ToString();
        }

        if(score.nb == scoreToGet)
        {
            victoryUI.SetActive(true);
            GameUI.SetActive(false);
            
            Time.timeScale = 0f;

            float scoreTime = initialTime - timeLeft.nb;
            int minutes = Mathf.FloorToInt(scoreTime / 60);
            int seconds = Mathf.FloorToInt(scoreTime % 60);
            timeDoneText.text = new StringBuilder()
                                .Append("In only ")
                                .Append(minutes)
                                .Append(" minute(s) and ")
                                .Append(seconds)
                                .Append(" seconds")
                                .ToString();

        }
    }
}
