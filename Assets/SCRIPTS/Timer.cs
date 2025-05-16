using UnityEngine;
using TMPro;
using System.Text;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerTxt, endTxt, scoreTxt;
    [SerializeField] private FloatReference remainingTime;
    [SerializeField] private GameObject endUI, gameUI;
    [SerializeField] private IntReference score;
    void Update()
    {
        if(remainingTime.nb>0)
        {
            remainingTime.nb -= Time.deltaTime;
        } 
        else if(remainingTime.nb <=0)
        {
            remainingTime.nb = 0;
            endUI.SetActive(true);
            gameUI.SetActive(false);
            endTxt.text = "Time over ! You did well ! Your score: ";
            scoreTxt.text = score.nb.ToString();
        }

        int minutes=Mathf.FloorToInt(remainingTime.nb /60);
        int seconds = Mathf.FloorToInt(remainingTime.nb % 60);
        timerTxt.text = new StringBuilder()
                            .AppendFormat("{0:D2}:{1:D2}", minutes, seconds)
                            .ToString();
    }
}
