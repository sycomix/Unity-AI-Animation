/*
┌─────────────────────────────────────────────────────────────────────────┐
│  Author: Ivan Murzak (https://github.com/IvanMurzak)                    │
│  Repository: GitHub (https://github.com/IvanMurzak/Unity-AI-Animation)  │
│  Copyright (c) 2025 Ivan Murzak                                         │
│  Licensed under the Apache License, Version 2.0.                        │
│  See the LICENSE file in the project root for more information.         │
└─────────────────────────────────────────────────────────────────────────┘
*/

#nullable enable

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.IvanMurzak.McpPlugin;
using UnityEngine;

namespace com.IvanMurzak.Unity.MCP.Animation
{
    public static partial class AnimationTools
    {
        [McpPluginTool
        (
            "animation-create",
            Title = "Animation / Create"
        )]
        [Description(@"Create Unity's Animation asset file.")]
        public static void Create
        (
            [Description("The paths of the asset to create.")]
            string[] sourcePaths
        )
        {

        }
    }
}