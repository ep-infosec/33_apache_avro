/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;

namespace Avro
{
    /// <summary>
    /// CodeGen Exception.
    /// </summary>
    /// <seealso cref="Avro.AvroException" />
    public class CodeGenException : AvroException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGenException"/> class.
        /// </summary>
        public CodeGenException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGenException"/> class.
        /// </summary>
        /// <param name="s">The message that describes the error.</param>
        public CodeGenException(string s)
            : base(s)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGenException"/> class.
        /// </summary>
        /// <param name="s">The message that describes the error.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference
        /// if no inner exception is specified.</param>
        public CodeGenException(string s, Exception inner)
            : base(s, inner)
        {
        }
    }
}
