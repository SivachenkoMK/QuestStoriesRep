using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public List<Slide> SlidesOfQuest;

    public Slide GetSlide()
    {
        foreach (Slide s in SlidesOfQuest)
        {
            if (s.Number == "1")
                return s;
        }
        return null;
    }
    public Slide GetSlide(string x)
    {
        foreach (Slide s in SlidesOfQuest)
        {
            if (s.Number == x)
                return s;
        }
        return null;
    }

    public void AddSlide(Slide s)
    {
        if (s != null)
        SlidesOfQuest.Add(s);
    }
}
