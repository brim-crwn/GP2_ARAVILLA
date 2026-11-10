using UnityEngine;
using System.Collections.Generic;

//progress,Finished,notstarted
public enum QuestStatus
{
    NotStarted,
    Inprogress,
    Completed
}
public class QuestLog : MonoBehaviour
{

    //Dictionary<Key,Value>
    //Dictionary<QuestName("String"), QuestStatus(ENum)>
    //Key = We want to look up/ we want to find
    //Value = Definition
    //ex: sorting high scores
    //Dictionary <string(PlayerName), int(PlayerScore)>
    //ex: How many Item do we have
    //Dictionary <string(itemName), int(itemQuantity)>

    private Dictionary<string,QuestStatus> activeQuests = new Dictionary<string, QuestStatus>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activeQuests.Add("Kill 10 Rats", QuestStatus.Inprogress);
        
    }

    public void CheckQuest(string questname)
    {
        if (activeQuests.ContainsKey(questname))
        {
            QuestStatus status = activeQuests[questname];
            Debug.Log($"Quest '{questname}' is currently: {status}");
        }
        else
        {
            Debug.Log($"you Don't have the Quest '{questname}'");
        }
    }

    public void UpdateQuest(string questname, QuestStatus newstatus)
    {
        if(activeQuests.ContainsKey(questname))
        {
            activeQuests[questname] = newstatus;
            Debug.Log($"Quests '{questname} updated to : {newstatus}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
