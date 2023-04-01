using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class MemoryFragmentShootable : MonoBehaviour, IShootable
{
    [SerializeField] private int amountOfHitsNeeded;
    [Range(0, 100)]
    [SerializeField] private int percentScaleIncrease;
    private float sizeScale;
    private SpringValue spring;

    [Header("Spring Settings")]
    [SerializeField] private float stiffness;
    [SerializeField] private float damping;
    

    private void Start()
    {
        spring = new SpringValue(this.transform.localScale.x, stiffness, damping);
        sizeScale = (percentScaleIncrease / 100f) * transform.localScale.x;
    }
    private void Update()
    {
        spring.Update(Time.deltaTime);
        float temp = Mathf.Clamp(spring.value, 0, 10);
        transform.localScale = new Vector3(temp, temp, temp);
    }

    public void Hit()
    {
        amountOfHitsNeeded -= 1;
        spring.targetValue += sizeScale;
        spring.Nudge(1);
        if (amountOfHitsNeeded <= 0)
        {
            Destroy(gameObject.GetComponent<BoxCollider>());
            spring.targetValue = 0;
            Destroy(gameObject, 2);
            //enter behavior to change level
        }
    }

}
