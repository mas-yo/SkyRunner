using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SkyRunner
{
    public struct GameInput
    {
        public bool Left;
        public bool Right;
        
        public static GameInput CalcGameInput(Touch[] touches)
        {
            return new GameInput()
            {
                Left = true,
                Right = true,
            };
        }
    }
    
}
