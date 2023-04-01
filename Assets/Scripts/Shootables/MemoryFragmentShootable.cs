using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryFragmentShootable : MonoBehaviour, IShootable
{
    [SerializeField] private int amountOfHitsNeeded;
    public void Hit()
    {
        amountOfHitsNeeded -= 1;
        if (amountOfHitsNeeded <= 0)
        {
            Destroy(this);
            //enter behavior to change level
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
