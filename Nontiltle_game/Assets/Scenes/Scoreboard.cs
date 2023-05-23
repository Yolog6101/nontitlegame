using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI board;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        board.text="Chicken\nCokkie";//boardに登録したテキストオブジェクトの文字を変える
    }
}
