using UnityEngine;

public class GameStarter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsStarted", true);
        }
        if (OVRInput.Get(OVRInput.Button.Two)|| Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("IsStarted", false);
        }
    }
}
