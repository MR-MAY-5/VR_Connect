using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Timer
{
    public class Stopwatch : MonoBehaviour
    {
        public TextMeshProUGUI timerText;
        [SerializeField] private ParticleSystem ooo;


        private bool isRunning = false;
        private float elapsedTime = 0f;
        int minutes;
        int seconds;
        int milliseconds;
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
            if (seconds > 5 /*&& this.gameObject.CompareTag("Lside") || this.gameObject.CompareTag("Rside")*/)
            {
                if (this.gameObject.CompareTag("Lside"))
                {
                    appreciation();
                }
                else if (this.gameObject.CompareTag("Rside"))
                {
                    appreciation();
                }

            }

        }

        public void StartTimer()
        {
            isRunning = true;

        }

        public void StopTimer()
        {
            isRunning = false;

        }

        void UpdateTimerText()
        {
            minutes = Mathf.FloorToInt(elapsedTime / 60f);
            seconds = Mathf.FloorToInt(elapsedTime % 60f);
            // milliseconds = Mathf.FloorToInt((elapsedTime * 1000f) % 1000f);



            string timeString = string.Format("{0:00}:{1:00}", minutes, seconds /*milliseconds*/);
            timerText.text = timeString;
        }
        void appreciation()
        {
            Debug.Log("yeah yeah like that");


        }



    }
}