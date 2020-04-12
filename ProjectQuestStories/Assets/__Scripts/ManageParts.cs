using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageParts : MonoBehaviour
{
    public GameObject ZeroPart;
    public GameObject FirstPart;
    public GameObject SecondPart;
    public GameObject ThirdPart;
    public GameObject FourthPart;
    public GameObject SlidePart;
    public GameObject SixthPart;
    public GameObject LastSlidePart;

    private bool CanGoNext(params string[] s)
    {
        foreach (string line in s)
        {
            if (line == null || line == "")
                return false;
        }
        return true;
    }
    private void CantGoNext()
    {

    }
    public void OpenZeroPart()
    {
        ZeroPart.SetActive(true);
    }
    private void DecideWhereToGoFromZeroPart()
    {

    }
    public void GoFromZeroPart()
    {
        ZeroPart.SetActive(false);
        DecideWhereToGoFromZeroPart();
    }
    public void OpenFirstPart()
    {
        FirstPart.SetActive(true);
    }
    private void GoFromFirstPart()
    {
        FirstPart.SetActive(false);
    }
    private void OpenSecondPart()
    {
        SecondPart.SetActive(true);
    }
    public void EndFirstPart()
    {
        if (CanGoNext(SlideData.CreatorSlide.Name))
        {
            GoFromFirstPart();
            OpenSecondPart();
        }
    }
    private void GoFromSecondPart()
    {
        SecondPart.SetActive(false);
    }
    private void OpenThirdPart()
    {
        ThirdPart.SetActive(true);
    }
    public void EndSecondPart()
    {
        if (CanGoNext(SlideData.CreatorSlide.Story))
        {
            GoFromSecondPart();
            OpenThirdPart();
        }
    }
    private void DecideWhereToGoFromThirdPart()
    {
        if (SlideData.CreatorSlide.QuantityOfOptions == 0)
            ShowSlide();
        else
            OpenFourthPart();
    }
    public void EndThirdPart()
    {
        ThirdPart.SetActive(false);
        DecideWhereToGoFromThirdPart();
    }
    private void DisplayFourthPart()
    {
        GiveAsManyButtonsAsOptions(FourthPart);
    }
    private void OpenFourthPart()
    {
        FourthPart.SetActive(true);
        DisplayFourthPart();
    }
    public void GetTextFor1Option()
    {
        SlideData.CreatorSlide.Option1Text = GameObject.Find("Text1Button").GetComponent<Text>().text;
    }
    public void GetTextFor2Option()
    {
        SlideData.CreatorSlide.Option2Text = GameObject.Find("Text2Button").GetComponent<Text>().text;
    }
    public void GetTextFor3Option()
    {
        SlideData.CreatorSlide.Option3Text = GameObject.Find("Text3Button").GetComponent<Text>().text;
    }
    private void GoFromFourthPart()
    {
        FourthPart.SetActive(false);
    }
    public void EndFourthPart()
    {
        if ((CanGoNext(SlideData.CreatorSlide.Option1Text) && SlideData.CreatorSlide.QuantityOfOptions == 1) ||
            CanGoNext(SlideData.CreatorSlide.Option1Text, SlideData.CreatorSlide.Option2Text) && SlideData.CreatorSlide.QuantityOfOptions == 2 ||
            CanGoNext(SlideData.CreatorSlide.Option1Text, SlideData.CreatorSlide.Option2Text, SlideData.CreatorSlide.Option3Text) && SlideData.CreatorSlide.QuantityOfOptions == 3)
        {
            GoFromFourthPart();
            ShowSlide();
        }
    }
    private void SetText1OnSlide()
    {
        if (SlideData.CreatorSlide.QuantityOfOptions >= 1)
        {
            GameObject.Find("TextForFirstButton").GetComponent<Text>().text = SlideData.CreatorSlide.Option1Text;
        }
    }
    private void SetText2OnSlide()
    {
        if (SlideData.CreatorSlide.QuantityOfOptions >= 2)
        {
            GameObject.Find("TextForSecondButton").GetComponent<Text>().text = SlideData.CreatorSlide.Option2Text;
        }
    }
    private void SetText3OnSlide()
    {
        if (SlideData.CreatorSlide.QuantityOfOptions >= 3)
        {
            GameObject.Find("TextForThirdButton").GetComponent<Text>().text = SlideData.CreatorSlide.Option3Text;
        }
    }
    private void UploadTextForButtonsOnSlide()
    {
        SetText1OnSlide();
        SetText2OnSlide();
        SetText3OnSlide();
    }
    private void DisplayTheStory()
    {
        GameObject.Find("StoryOnSlide").GetComponent<Text>().text = SlideData.CreatorSlide.Story;
    }
    private void DisplayComponentsOnSlide()
    {
        DisplayTheStory();
        UploadTextForButtonsOnSlide();
    }
    private void DisplaySlide()
    {
        GiveAsManyButtonsAsOptions(SlidePart);
        DisplayComponentsOnSlide();
    }
    public void ShowSlide()
    {
        SlidePart.SetActive(true);
        DisplaySlide();
    }
    private void GoFromSlide()
    {
        SlidePart.SetActive(false);
    }
    public void EndSLidePart()
    {
        GoFromSlide();
        OpenSixthPart();
    }
    private void OpenSixthPart()
    {
        SixthPart.SetActive(true);
        DisplaySixthPart();
    }
    private void SlideNumberSettingsOnSixthPart()
    {
        if (SlideData.CreatorSlide.Number == "" || SlideData.CreatorSlide.Number == null)
            GameObject.Find("GetThisSlideNumber").SetActive(true);
        else
            GameObject.Find("GetThisSlideNumber").SetActive(false);
    }
    private void SlideReferencesSettings()
    {
        DisplayTextForReferencesOnSixthPart();
        SetReferencesForSlide();
    }
    private void DisplayTextForReferencesOnSixthPart()
    {
        if (SlideData.CreatorSlide.QuantityOfOptions == 0)
            GameObject.Find("TextThatExplainsReferences").SetActive(false);
        else
            GameObject.Find("TextThatExplainsReferences").SetActive(true);
    }
    private void DisplaySixthPart()
    {
        SlideNumberSettingsOnSixthPart();
        SlideReferencesSettings();
    }
    private void SetReferencesForSlide()
    {
        GiveAsManyButtonsAsOptions(GameObject.Find("GetReferenceForOptions"));
    }
    public void GetSlideReference(string s)
    {
        if (s != "" || s != null)
        {
            SlideData.CreatorSlide.Number = s;
        }
        else
        {
            s = "";
            SlideData.CreatorSlide.Number = null;
        }
    }
    public void GetReferenceForOrtion1(string s)
    {
        if (s != "" || s != null)
        {
            SlideData.CreatorSlide.Option1reference = s;
        }
        else
        {
            s = "";
            SlideData.CreatorSlide.Option1reference = null;
        }
    }
    public void GetReferenceForOption2(string s)
    {
        if (s != "" || s != null)
        {
            SlideData.CreatorSlide.Option2reference = s;
        }
        else
        {
            s = "";
            SlideData.CreatorSlide.Option2reference = null;
        }
    }
    public void GetReferenceForOption3(string s)
    {
        if (s != "" || s != null)
        {
            SlideData.CreatorSlide.Option3reference = s;
        }
        else
        {
            s = "";
            SlideData.CreatorSlide.Option3reference = null;
        }
    }
    private void GoFromSixthPart()
    {
        AddSlideToQuest();
        SixthPart.SetActive(false);
    }
    public void EndSixthPart()
    {
        if ((SlideData.CreatorSlide.QuantityOfOptions == 1 && CanGoNext(SlideData.CreatorSlide.Option1reference, SlideData.CreatorSlide.Number)) || 
            (SlideData.CreatorSlide.QuantityOfOptions == 2 && CanGoNext(SlideData.CreatorSlide.Option1reference, SlideData.CreatorSlide.Option2reference, SlideData.CreatorSlide.Number)) ||
            (SlideData.CreatorSlide.QuantityOfOptions == 3 && CanGoNext(SlideData.CreatorSlide.Option1reference, SlideData.CreatorSlide.Option2reference, SlideData.CreatorSlide.Option3reference, SlideData.CreatorSlide.Number)))
        {
            GoFromSixthPart();
            OpenLastSlidePart();
        }
        else
        {
            CantGoNext();
        }
        print(SlideData.CreatorSlide.Number);
        print(SlideData.CreatorSlide.Option1reference);
        print(SlideData.CreatorSlide.Option2reference);
        print(SlideData.CreatorSlide.Option3reference);
    }
    private void OpenLastSlidePart()
    {
        LastSlidePart.SetActive(true);
    }
    private void AddSlideToQuest()
    {
        QuestData.QuestOnCreation.AddSlide(SlideData.CreatorSlide);
    }
    private void GoFromLastPart()
    {
        LastSlidePart.SetActive(false);
    }
    private void MakeSlideDataZero()
    {
        SlideData.CreatorSlide = null;
    }
    public void EndLastPart()
    {
        GoFromLastPart();
        OpenZeroPart();
        MakeSlideDataZero();
    }
    private void GiveAsManyButtonsAsOptions(GameObject G)
    {
        switch (SlideData.CreatorSlide.QuantityOfOptions)
        {
            case 0:
                {
                    G.transform.GetChild(0).gameObject.SetActive(false);
                    G.transform.GetChild(1).gameObject.SetActive(false);
                    G.transform.GetChild(2).gameObject.SetActive(false);
                    break;
                }
            case 1:
                {
                    G.transform.GetChild(1).gameObject.SetActive(false);
                    G.transform.GetChild(2).gameObject.SetActive(false);
                    break;
                }
            case 2:
                {
                    G.transform.GetChild(2).gameObject.SetActive(false);
                    break;
                }
            case 3:
                {
                    break;
                }
        }
    }
}
