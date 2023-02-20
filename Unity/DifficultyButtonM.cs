using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonM : MonoBehaviour
{
    private Button button;
    private SpawnManagerM spawnManagerM;
    public int difficulty;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        spawnManagerM = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerM>();
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        spawnManagerM.StartGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
