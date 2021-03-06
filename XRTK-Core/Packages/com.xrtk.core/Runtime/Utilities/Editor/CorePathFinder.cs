﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace XRTK.Utilities.Editor
{
    /// <summary>
    /// Dummy scriptable object used to find the relative path to com.xrtk.core.
    /// </summary>
    /// <inheritdoc cref="IPathFinder" />
    public class CorePathFinder : ScriptableObject, IPathFinder
    {
        /// <inheritdoc />
        public string Location => $"/Runtime/Utilities/Editor/{nameof(CorePathFinder)}.cs";
    }
}