using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    
    public GameObject applePrefab; // Prefab for instantiating apples

    public float speed = 1f; // Speed at which the AppleTree moves

    public float leftAndRightEdge = 10f; // Distance where AppleTree turns around

    public float changeDirChance = 0.1f; // Chance that the AppleTree will change directions

    public float appleDropDelay = 1f; // Seconds between Apple instantiations

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start dropping apples
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        // Changing Direction
    }
}
