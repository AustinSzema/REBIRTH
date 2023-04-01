using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private bool hitAlready = false;
    void Start()
    {
        Destroy(this, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hitAlready) { return; }
        IShootable shootable =  collision.gameObject.GetComponent<IShootable>();
        if (shootable != null)
        {
            shootable.Hit();
        }
        hitAlready = true;
        Debug.Log("hit");
    }
}
