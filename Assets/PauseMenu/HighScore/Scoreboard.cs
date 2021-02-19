
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


namespace FBLA.Scoreboard
{
    public class Scoreboard : MonoBehaviour
    {
        public GameObject newHighScore;
        
        [SerializeField] private int maxScoreboardEntries = 3;
        [SerializeField] private Transform highscoresHolderTransform = null;
        [SerializeField] private GameObject scoreboardEntryObject = null;

        [Header("Test")]
        [SerializeField] ScoreboardEntryData testEntrydata = new ScoreboardEntryData();

        private string SavePath => $"{Application.persistentDataPath}/highscores.json";
             
        private void Start()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            ScoreboardSaveData savedScores = GetSavedScores();

            SaveScores(savedScores);

            UpdateUI(savedScores);

            AddEntry(testEntrydata);

            
            
        }

        /*[ContextMenu("Add Test Entry")]
        public void AddTestEntry()
        {
            AddEntry(testEntrydata);
        }*/

        public void AddEntry(ScoreboardEntryData scoreboardEntryData)
        {
            scoreboardEntryData.entryScore = PlayerPrefs.GetInt("Score");
            scoreboardEntryData.entryName = PlayerPrefs.GetString("name");
            ScoreboardSaveData savedScores = GetSavedScores();

            
            bool scoreAdded = false;

                for(int i=0;i<savedScores.highscores.Count; i++)
                {
                    if (scoreboardEntryData.entryScore > savedScores.highscores[i].entryScore)
                    {             
                        //if you press button score will not be placed
                        if(scoreboardEntryData.entryScore == 9999)
                        {
                        scoreAdded = false;
                        break;
                        }
                        savedScores.highscores.Insert(i, scoreboardEntryData);
                        scoreAdded = true;
                        break;
                    }                                    
                                       

                }

            if (scoreboardEntryData.entryScore > savedScores.highscores[1].entryScore)
            {
                //newHighScore.SetActive(true);

                StartCoroutine(setHighscore());

                Debug.Log("highscore");
            }

            IEnumerator setHighscore()
                {
                    newHighScore.SetActive(true);

                    yield return new WaitForSeconds(3);
                    newHighScore.SetActive(false);
                }
                
                if(!scoreAdded && savedScores.highscores.Count<maxScoreboardEntries)
                {
                    savedScores.highscores.Add(scoreboardEntryData);
                }

                if(savedScores.highscores.Count > maxScoreboardEntries)
                {
                    savedScores.highscores.RemoveRange(
                        maxScoreboardEntries, 
                        savedScores.highscores.Count - maxScoreboardEntries);
                }

            UpdateUI(savedScores);

            SaveScores(savedScores);
        }

        private void UpdateUI(ScoreboardSaveData savedScores)
        {
            foreach(Transform child in highscoresHolderTransform)
            {
                Destroy(child.gameObject);
            }

            foreach(ScoreboardEntryData highscore in savedScores.highscores)
            {
                Instantiate(scoreboardEntryObject, highscoresHolderTransform).
                    GetComponent<ScoreboardEntryUI>().Initialise(highscore);
            }
        }

        private ScoreboardSaveData GetSavedScores()
        {
            if (!File.Exists(SavePath))
            {
                File.Create(SavePath).Dispose();
                return new ScoreboardSaveData();
            }

            using(StreamReader stream = new StreamReader(SavePath))
            {
                string json = stream.ReadToEnd();

                return JsonUtility.FromJson<ScoreboardSaveData>(json);
            }
        }         
        
        private void SaveScores(ScoreboardSaveData scoreboardSaveData)
        {
            using(StreamWriter stream= new StreamWriter(SavePath))
            {
                string json = JsonUtility.ToJson(scoreboardSaveData, true);

                stream.Write(json);
            }
        }
    }
}