using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dye : MonoBehaviour
{
    private SpriteRenderer _sprite;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _sprite.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    private void Update()
    {
        
    }
}
