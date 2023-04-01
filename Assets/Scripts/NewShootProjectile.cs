using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShootProjectile : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileSpeed = 50f;
    [SerializeField] private Transform shootingPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);
                projectile.GetComponent<Rigidbody>().velocity = shootingPoint.forward * projectileSpeed;
                projectile.transform.forward = shootingPoint.transform.forward;
                projectile.transform.Rotate(0f, 180f, 0f);
                projectile.transform.position += new Vector3(0f, 0.5f, 0f);
    
        }
    }
}
