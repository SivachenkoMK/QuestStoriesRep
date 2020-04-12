using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideData : MonoBehaviour
{
    // Страница
    public static Slide CreatorSlide = new Slide();

    public void GetNameForSlide()
    {
        CreatorSlide.Name = GameObject.Find("TextNameOfSlide").GetComponent<Text>().text;
    }

    public void GetStoryForSlide()
    {
        CreatorSlide.Story = GameObject.Find("TextStoryOfSlide").GetComponent<Text>().text;
    }

    public void GetQuantityOfButtons()
    {
        CreatorSlide.QuantityOfOptions = GameObject.Find("Dropdown").GetComponent<Dropdown>().value;
    }

    public void SaveSlideReference()
    {
        CreatorSlide.Number = GetComponent<Text>().text;
    }

    public void SaveFirstOptionReference()
    {
        CreatorSlide.Option1reference = GetComponent<Text>().text;
    }

    public void SaveSecondOptionReference()
    {
        CreatorSlide.Option2reference = GetComponent<Text>().text;
    }

    public void SaveThirdOptionReference()
    {
        CreatorSlide.Option3reference = GetComponent<Text>().text;
    }
}
