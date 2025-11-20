using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [field: SerializeField] public string QuestId;
    [field: SerializeField] private string QuestName;
    private QuestState state = QuestState.NotStarted;
    [field: SerializeField] public List<QuestTasks> Tasks = new();

    private Action OnQuestStarted;
    private Action OnQuestCompleted;


    public void StartQuest()
    {
        if (state == QuestState.NotStarted)
        {
            state = QuestState.InProgress;
            OnQuestStarted?.Invoke();
        }
    }

    public void CompleteQuest()
    {
        if (state == QuestState.InProgress)
        {
            state = QuestState.Completed;
            OnQuestCompleted?.Invoke();
        }
    }


    public void UpdateTask(string taskId, int amount)
    {
        if(state != QuestState.InProgress) { return; }
        var task = Tasks.Find(t => t.TaskId == taskId);
        task?.UpdateProgress(amount);
    }


    public enum QuestState
    {
        NotStarted,
        InProgress,
        Completed,
    }
}
