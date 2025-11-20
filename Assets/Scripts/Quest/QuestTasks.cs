using UnityEngine;
using UnityEngine.Events;

public class QuestTasks
{
    [field: SerializeField] private string description;
    [field: SerializeField] public string TaskId;
    [field: SerializeField] private int TargetProgress;
    private int currentProgress;
    private bool isCompleted;

    public UnityEvent OnTaskCompleted;

    private void CompleteTask()
    {
        isCompleted = true;
        OnTaskCompleted?.Invoke();
    }

    public void UpdateProgress(int amount)
    {      
        if (isCompleted) { return; }
        currentProgress = Mathf.Min(currentProgress + amount, TargetProgress);
        if(currentProgress >= TargetProgress) { CompleteTask(); }
    }
}