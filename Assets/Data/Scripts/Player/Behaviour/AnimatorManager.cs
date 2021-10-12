using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class AnimatorManager : MonoBehaviour
    {
        public Animator anim;

        public void PlayTargetAnimation(string targetAnim, bool IsInteracting)
        {
            anim.applyRootMotion = IsInteracting;
            anim.SetBool("IsInteracting", IsInteracting);
            anim.CrossFade(targetAnim, 0.2f);
        }
    }
}
