﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Console
{
    static class ConsoleUtility
    {
        [RuntimeInitializeOnLoadMethod]
        static void CreateConsole()
        {
            var prefab = GameObject.Instantiate(Resources.Load<GameObject>("Console"));
            prefab.name = "Console";
            GameObject.DontDestroyOnLoad(prefab);
            
        }
    }
}

