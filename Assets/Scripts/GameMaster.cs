using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster instance;

    public Player player = new Player();
    public class Player
    {
        private float gold;
        public float playerGold
        {
            get
            {
                return gold;
            }
            set
            {
                gold = value;
                if (value < 0)
                    gold = 0;

            }
        }
    }

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
        player.playerGold = 200f;

    }


}
