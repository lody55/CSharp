using UnityEngine;

namespace Pr
{
    
    public class delegatePr : MonoBehaviour
    {
        public delegate void QuestHandler(string questName);
        public static event QuestHandler OnDead;
           
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            QuestHandler quest = CompleteQuest;
            quest += ShowQuestResult;

            quest?.Invoke("사자의 심장");
            
        }

        void CompleteQuest(string questName)
        {
            Debug.Log($"퀘스트 실행 : {questName}");
        }
        void ShowQuestResult(string quest)
        {
            Debug.Log($"퀘스트 완료 : {quest}");
        }
    }
}