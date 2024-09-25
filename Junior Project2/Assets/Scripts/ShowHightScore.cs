using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowHightScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.loadHightScore();
        bestScoreText.text = "Best Score : " + DataManager.instance.hightPlayerName + " : " + DataManager.instance.hightPlayerPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
