using UnityEngine;

public class HamburgerMenuController : MonoBehaviour
{
    public GameObject hamburger;

    public void setHamburgerVisible()
    {
        Animator animator = hamburger.GetComponent<Animator>();

        bool isVisible = animator.GetBool("Visible");
        Debug.Log(isVisible);
        animator.SetBool("Visible", !isVisible);
    }
}