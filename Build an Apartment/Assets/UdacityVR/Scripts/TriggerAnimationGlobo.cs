using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationGlobo : MonoBehaviour {


    [Tooltip("The Animator component on this gameobject")]
    public Animator animator;
    [Tooltip("The name of the Animator trigger parameter")]
    public string triggerName;

    void Update()
    {
        // If the player pressed the cardboard button (or touched the screen), set the trigger parameter to active (until it has been used in a transition)
        if (Input.GetMouseButtonDown(1))
        {
            if (animator == null)
            {
                Debug.LogWarning("Please add an animator to your " + gameObject.name);
                return;
            }
            if (triggerName == null)
            {
                Debug.LogWarning("What's the trigger parameter name you want to call? Please add it to the TriggerAnimation script on your " + gameObject.name);
                return;
            }
            animator.SetTrigger(triggerName);
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogWarning("Please add an animator to your " + gameObject.name);
        }
    }
}