
using UnityEngine;

public class ProximityAnimator : MonoBehaviour
{
    public Transform otherBear;   // set manually in Inspector
    public float attackDistance = 0.2f; // distance in Unity meters

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (otherBear == null || anim == null) return;

        float dist = Vector3.Distance(transform.position, otherBear.position);

        if (dist <= attackDistance)
        {
            anim.SetTrigger("Attack");
        }
        else
        {
            anim.ResetTrigger("Attack");
        }

    }
}
