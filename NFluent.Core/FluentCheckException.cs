﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FluentCheckException.cs" company="">
//   Copyright 2013 Thomas PIERRAIN
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    using System;

    /// <summary>
    /// Thrown when an check failed.
    /// </summary>
#if !(PORTABLE) && !(CORE)
    [Serializable]
#endif
    public class FluentCheckException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FluentCheckException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public FluentCheckException(string message)
            : base(message)
        {
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="FluentCheckException" /> class.
        ///// </summary>
        ///// <param name="info">The info.</param>
        ///// <param name="context">The context.</param>
        // protected FluentCheckException(SerializationInfo info, StreamingContext context)
        //    : base(info, context)
        // {
        // }
    }
}