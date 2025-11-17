using UnityEngine;

public class FoodObject : CellObject
{
    public int AmountGranted = 10;

    [SerializeField] private AudioClip pickupSound;

    public override void PlayerEntered()
    {

        var player = GameManager.Instance.PlayerController;

        if (pickupSound != null && player != null)
        {
            AudioSource audioSource = player.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.PlayOneShot(pickupSound);
            }
        }

        //increase food
        GameManager.Instance.ChangeFood(AmountGranted);
        Destroy(gameObject);
    }
}