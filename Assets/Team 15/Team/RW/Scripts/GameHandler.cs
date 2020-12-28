using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace t15
{
    public class GameHandler : MonoBehaviour
    {
        public Text UIText;
        public string startText;
        public string winText;

        // Start is called before the first frame update
        void Start()
        {
            UIText.text = startText;
            MinigameManager.Instance.minigame.gameWin = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Space"))
            {
                if (!MinigameManager.Instance.minigame.gameWin)
                {
                    MinigameManager.Instance.minigame.gameWin = true;
                    UIText.text = winText;
                    MinigameManager.Instance.PlaySound("win");
                }
            }
        }
    }
}
