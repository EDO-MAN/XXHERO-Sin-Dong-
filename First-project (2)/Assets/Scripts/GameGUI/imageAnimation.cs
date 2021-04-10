using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageAnimation : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private Image _image;

    void Start()
    {
        if (_spriteRenderer == null)
            _spriteRenderer = this.GetComponent<SpriteRenderer>();

        _spriteRenderer.enabled = false;

        if (_image == null)
            _image = this.GetComponent<Image>();
    }

    void Update()
    {
        _image.sprite = _spriteRenderer.sprite;
    }
}
