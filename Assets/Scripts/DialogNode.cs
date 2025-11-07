using System;
using System.Collections.Generic;
using UnityEngine;

internal sealed class DialogNode : MonoBehaviour
{
    public string text;
    public List<DialogOption> nodes = new List<DialogOption>();
    public Func<bool> CanShowNode;
    public event Action OnNodeCompleted;

    public void CompleteNode()
    {
        OnNodeCompleted?.Invoke();
    }
}

