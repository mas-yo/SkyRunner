using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyRunner
{
    public struct Component<T>
    {
        private int EntityId;
        private T data;
    }
    
}
