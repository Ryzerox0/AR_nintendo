using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerTxt;
    [SerializeField] private FloatReference remainingTime;
    void Update()
    {
        if(remainingTime.nb>0)
            remainingTime.nb -= Time.deltaTime;
        else if(remainingTime.nb <=0) 
            remainingTime.nb =0;
        /*
           [TODO]
            -Afficher écran récapitulatif du score (utiliser le victory screen et changer le texte)
         */
        int minutes=Mathf.FloorToInt(remainingTime.nb /60);
        int seconds = Mathf.FloorToInt(remainingTime.nb % 60);
        timerTxt.text = minutes+":"+seconds;
    }
}
