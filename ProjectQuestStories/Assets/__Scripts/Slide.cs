using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide : MonoBehaviour
{
    // Имя страницы (для удобства создателя)
    public string Name;
    // История на странице.
    public string Story;
    // Номер-ссылка на слайд
    public string Number;
    // Количество вариантов ответа
    public int QuantityOfOptions;
    // Ссылка на первый вариант ответа
    public string Option1reference;
    // Ссылка на второй вариант ответа
    public string Option2reference;
    // Ссылка на третий вариант ответа
    public string Option3reference;
    // Текст на первой развилке
    public string Option1Text;
    // Текст на второй развилке
    public string Option2Text;
    // Текст на третьей развилке
    public string Option3Text;
    public Slide()
    {

    }
}
