using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public GameController GameController;
    private Animator animator;
    private bool IsOn;
    [SerializeField] private float cooldown;
    private float cooldownTimer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            if (IsOn == true) {
                GameController.Die();
            }
        }
    }


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer < 0) {
            IsOn = !IsOn;
            cooldownTimer = cooldown;
        }
        animator.SetBool("IsOn", IsOn);
    }
}
