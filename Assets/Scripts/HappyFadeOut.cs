using UnityEngine;

public class HappyFadeOut : MonoBehaviour
{
    private Animator m_Animator;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        m_Animator.SetBool("isGrounded",true);
    }

}
