using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private PlayerInventory player;
    private bool opened = false;

    void Update()
    {
        if (player != null && !opened && Input.GetKeyDown(KeyCode.E))
        {
            player.AddBlocks(6);
            opened = true;

            Debug.Log("You got 6 blocks!");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            player = other.GetComponent<PlayerInventory>();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            player = null;
    }
}