using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TriggerParticles : MonoBehaviour
{
    public GameObject particle1;
    //public ParticleSystem particle2;
    public TextMeshProUGUI timerText;
 


  
    private float elapsedTime = 0f;
    int minutes;
    int seconds;
    int milliseconds;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            particle1.SetActive(true);
            //particle2.Play();
            elapsedTime += Time.deltaTime;
            UpdateTimerText();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            particle1.SetActive(false);
            //particle2.Stop();


        }
    }
    private void Update()
    {

    }
    void UpdateTimerText()
    {
        minutes = Mathf.FloorToInt(elapsedTime / 60f);
        seconds = Mathf.FloorToInt(elapsedTime % 60f);
      



        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds /*milliseconds*/);
        timerText.text = timeString;
    }

}
