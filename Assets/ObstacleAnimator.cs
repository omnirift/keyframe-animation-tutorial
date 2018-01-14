using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimator : MonoBehaviour {

    private Animator animatorComponent;
    private Renderer rendererComponent;

    private const string WARP_OUT_NAME = "WarpOut";
    private const string WARP_IN_NAME = "WarpIn";

    // Use this for initialization
    void Start ()
    {
        animatorComponent = GetComponent<Animator>();
        rendererComponent = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animatorComponent.Play(WARP_OUT_NAME);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animatorComponent.Play(WARP_IN_NAME);
        }
    }

    public void Disable()
    {
        rendererComponent.enabled = false;
    }

    public void Enable()
    {
        rendererComponent.enabled = true;
    }
}
