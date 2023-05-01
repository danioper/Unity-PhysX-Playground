using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ragdollEnvoker : MonoBehaviour
{
    private Animator playerAnimator;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        playerAnimator.enabled = false;
    }
}
