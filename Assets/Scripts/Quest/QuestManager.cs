using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private List<Quest> completedQuests = new();
    private List<Quest> activeQuests = new();

    private void StartQuest(Quest quest)
    {
        activeQuests.Add(quest);
        quest.StartQuest();
    }

    private void CompleteQuest(Quest quest)
    {
        activeQuests.Remove(quest);
        completedQuests.Add(quest);
        quest.CompleteQuest();
    }

    private void UpdateQuestProgress(string questId, string taskId, int amount)
    {
        var quest = activeQuests.Find(q => q.QuestId == questId);
        quest?.UpdateTask(taskId, amount);
    }

}
