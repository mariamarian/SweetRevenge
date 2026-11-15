using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int blocks = 0;

    public void AddBlocks(int amount)
    {
        blocks += amount;
        Debug.Log("You got " + amount + " blocked!");
    }
}