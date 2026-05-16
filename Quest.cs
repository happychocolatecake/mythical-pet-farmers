using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool isActive;
    public bool completed;
    public bool currentQuest;
    public int numberQuest;

    public string title;
    public string description;
    public string recipient;
    public string colour;

    public QuestGoal goal;
    public QuestGiver questGiver;
    public SaveAndLoad saveAndLoad;

    public List<string> sentences; 
    public List<string> characterSpeaking;

    public void SetQuestGiver(QuestGiver questGiver)
    {
        this.questGiver = questGiver;
    }
}
