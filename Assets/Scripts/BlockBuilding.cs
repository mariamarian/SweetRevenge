using UnityEngine;

public class BlockBuilding : MonoBehaviour
{
    public GameObject blockPrefab;
    public Transform basePosition;
    public float blockHeight = 1f;

    private PlayerInventory player;

    void Update()
    {
        if (player != null && Input.GetKeyDown(KeyCode.E))
        {
            int amount = player.blocks;

            if (amount > 0)
            {
                Vector3[] positions =
                {
                    new Vector3(0, 0, 0),
                    new Vector3(1, 0, 0),
                    new Vector3(2, 0, 0),

                    new Vector3(1, 1, 0),
                    new Vector3(2, 1, 0),

                    new Vector3(2, 2, 0)
                };

                for (int i = 0; i < 6; i++)
                {
                    Vector3 position = basePosition.position +
                                       positions[i] * blockHeight;

                    Instantiate(blockPrefab, position, Quaternion.identity);
                }

                player.blocks = 0;
            }
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