﻿using System;

namespace Magicodes._64.Attributes
{
    public interface IMagicodesData
    {
        /// <summary>
        ///   Model Type  
        /// </summary>
        Type Type { get; set; }
        /// <summary>
        ///     Template Path
        /// </summary>
        string TemplatePath { get; set; }
    }
}
