using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartManage : MonoBehaviour
{
    public InputField StoryField;
    public GameObject TakingStory;
    public GameObject GetButtons;
    public GameObject InitButtons;

    public void IsSroryFilled()
    {
        if (StoryField.text.Length != 0)
        {
            GoToPartOfGettingNumbersOfButtons();
        }
    }

    private void GoToPartOfGettingNumbersOfButtons()
    {
        Destroy(TakingStory);
        Instantiate(GetButtons);
    }
}
