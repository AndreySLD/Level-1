using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class DayNightCycleHandler : MonoBehaviour
    {
        [Range(0.0f, 1.0f)]

        public float currentTime;
        public float fullDayLength;
        public float startTime = 0f;
        private float timeRate;

        public Vector3 noon;

        [Header("Sun")]
        public Light dayLight;
        public Material daySkybox;
        public Gradient sunColor;
        public AnimationCurve sunIntensity;
        [Header("Moon")]
        public Light nightLight;
        public Material nightSkybox;
        public Gradient moonColor;
        public AnimationCurve moonIntensity;

        private void Start()
        {
            timeRate = 1.0f / fullDayLength;
            currentTime = startTime;
        }
        private void Update()
        {
            currentTime += timeRate * Time.deltaTime;

            if (currentTime >= 1.0f)
            {
                currentTime = 0.0f;
            }

            dayLight.transform.eulerAngles = (currentTime - 0.25f) * noon * 4.0f;
            nightLight.transform.eulerAngles = (currentTime - 0.75f) * noon * 4.0f;

            dayLight.intensity = sunIntensity.Evaluate(currentTime);
            nightLight.intensity = moonIntensity.Evaluate(currentTime);

            dayLight.color = sunColor.Evaluate(currentTime);
            nightLight.color = moonColor.Evaluate(currentTime);

            if (dayLight.intensity == 0 && dayLight.gameObject.activeInHierarchy)
            {
                dayLight.gameObject.SetActive(false);
            }
            else if (dayLight.intensity > 0 && !dayLight.gameObject.activeInHierarchy)
            {
                dayLight.gameObject.SetActive(true);
            }

            if (nightLight.intensity == 0 && nightLight.gameObject.activeInHierarchy)
            {
                nightLight.gameObject.SetActive(false);
            }
            else if (nightLight.intensity > 0 && !nightLight.gameObject.activeInHierarchy)
            {
                nightLight.gameObject.SetActive(true);
            }
        }
    }
}
