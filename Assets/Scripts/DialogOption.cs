using UnityEngine;
using UnityEngine.Events;
internal class DialogOption : MonoBehaviour
{
    public string text;
    public UnityEvent OnSelect;
    public void Select() 
    {
        OnSelect?.Invoke();
    }
} 
