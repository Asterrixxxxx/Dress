using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public List<Sprite> images;
    private int currantSprite;
    private Image image;

    void Start()
    {
        currantSprite = 0;
        image = GetComponent<Image>();
    }

    public void ChangeSprite()
    {
        currantSprite++;
        if(currantSprite == images.Count)
            currantSprite = 0;
            image.sprite = images[currantSprite];
    } 
}
