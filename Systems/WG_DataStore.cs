using Game;
using Game.Audio;
using Game.Prefabs;
using Game.Simulation;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace WG_WorkerCapacityBooster
{
    public class DataStore
    {
        public const float MAX_SPACE_MULTIPLIER = 6f;
        public static float officeBooster = 3f;
    }
}