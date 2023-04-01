using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryFragmentShootable : MonoBehaviour, IShootable
{
    [SerializeField] private int amountOfHitsNeeded;
    public void Hit()
    {
        amountOfHitsNeeded -= 1;
        transform.localScale *= 1.1f;
        if (amountOfHitsNeeded <= 0)
        {
            Destroy(gameObject);
            //enter behavior to change level
        }
    }

}
