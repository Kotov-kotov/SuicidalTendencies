using UnityEngine;
using UnityEngine.Events;
internal sealed class DialogOption : MonoBehaviour
{
    [field: SerializeField] private string text; //что видит пользователь (текст варианта ответа)
    public string Text { get => text; set => text = value; }
    public UnityEvent OnSelect; //что вызывается при выборе опции


    public void Select() //метод для выбора опции 
    {
        OnSelect?.Invoke();
    }
} 
