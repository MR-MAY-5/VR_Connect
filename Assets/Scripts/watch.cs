using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Timer
{
    public class watch : MonoBehaviour
    {
        public TextMeshProUGUI timerText;
        //[SerializeField] private ParticleSystem ooo;


        private bool isRunning = false;
        private float elapsedTime = 0f;
        int minutes;
        int seconds;
        int milliseconds;

       [SerializeField] private GameObject particle;
        private void Start()
        {

        }

        private void Update()
        {
            if (isRunning)
            {
                elapsedTime += Time.deltaTime;
                UpdateTimerText();
            }
         
        }

        public void StartTimer()
        {
            isRunning = true;

        }

        public void StopTimer()
        {
            isRunning = false;
            if(particle.activeSelf)
            {
                particle.SetActive(false);
            }

        }

        void UpdateTimerText()
        {
            minutes = Mathf.FloorToInt(elapsedTime / 60f);
            seconds = Mathf.FloorToInt(elapsedTime % 60f);
            milliseconds = Mathf.FloorToInt((elapsedTime * 1000f) % 1000f);
            Debug.Log(minutes);
            Debug.Log(seconds);


            string timeString = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
            timerText.text = timeString;
            if (seconds >= 5)
            {
                Debug.Log("hi");
                particle.SetActive(true);
            }
        }


       
    }
}