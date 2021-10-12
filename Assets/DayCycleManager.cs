using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class DayCycleManager : MonoBehaviour
    {
        public Light Sun;
        public Light Moon;

        public ParticleSystem Stars;

        public AnimationCurve SunIntensivityCurve;
        public AnimationCurve MoonIntensivityCurve;
        public AnimationCurve SkyboxCurve;

        public Material DaySkybox;
        public Material NightSkybox;

        [Range(0, 1)]
        public float dayTime;
        public float dayDuration = 30f;

        private float sunIntesivity; 
        private float moonIntesivity;

        public bool isNight;

        private void Start()
        {
            sunIntesivity = Sun.intensity;
            moonIntesivity = Moon.intensity;
        }
        private void Update()
        {
            dayTime += Time.deltaTime / dayDuration;
            if (dayTime > 1)
            {
                dayTime = 0;
            }

            RenderSettings.skybox.Lerp(NightSkybox, DaySkybox, SkyboxCurve.Evaluate(dayTime));
            RenderSettings.sun = SkyboxCurve.Evaluate(dayTime) > 0.1f ? Sun : Moon;
            DynamicGI.UpdateEnvironment();

            var starsMain = Stars.main;
            starsMain.startColor = new Color(1, 1, 1, 1 - SkyboxCurve.Evaluate(dayTime));

            Sun.transform.localRotation = Quaternion.Euler(dayTime * 360f, 180, 0);
            Moon.transform.localRotation = Quaternion.Euler(dayTime * 360f + 180f, 180, 0);
            
            Sun.intensity = sunIntesivity * SunIntensivityCurve.Evaluate(dayTime);
            Moon.intensity = moonIntesivity * MoonIntensivityCurve.Evaluate(dayTime);

            if (dayTime > 0.5 && dayTime < 1)
            {
                isNight = true;
            }
            else
            {
                isNight = false;
            }
        }
    }
}
