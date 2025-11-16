using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    private Animator animationClip;
    private int crecer;

    void Start()
    {
        animationClip = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            animationClip.SetTrigger("Trigger");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            crecer += 1;
            animationClip.SetInteger("Crecer",crecer);
        }

    }
}
