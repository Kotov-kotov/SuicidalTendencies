using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

internal sealed class DialogNode : MonoBehaviour
{
    [field: SerializeField] private string text; //текст самого диалога
    public UnityEvent OnNodeCompleted; //действие, когда часть диалога завершен
    public Func<bool> CanShowNode; //можно/нельзя показать эту часть диалога 
    public IReadOnlyList<DialogOption> nodes = new List<DialogOption>(); //список вариантов ответов

    public string Text { get => text; set => text = value; }


    public void CompleteNode() //завершает часть диалога 
    {
        OnNodeCompleted?.Invoke();
    }
}

