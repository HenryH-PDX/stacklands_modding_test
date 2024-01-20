using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace testmod1NS
{
    public class testmod1 : Mod
    {
        public override void Ready()
        {
            Logger.Log("Ready!");
        }
    }
}