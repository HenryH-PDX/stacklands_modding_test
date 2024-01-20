using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace test_modNS
{
    public class test_mod : Mod
    {
        public override void Ready()
        {
            Logger.Log("Ready!");
        }
    }
}