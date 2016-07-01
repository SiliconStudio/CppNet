/*
 * Anarres C Preprocessor
 * Copyright (c) 2007-2008, Shevek
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied.  See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;

namespace CppNet
{
    /// <summary>
    /// Base class for listening to preprocessor warnings and errors.
    /// </summary>
    public abstract class PreprocessorListenerBase
    {
        private int	errors;
        private int	warnings;

        public void clear() {
            errors = 0;
            warnings = 0;
        }

        public int getErrors() {
            return errors;
        }

        public int getWarnings() {
            return warnings;
        }

        /// <summary>
        /// Handles a warning.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="line">The line.</param>
        /// <param name="column">The column.</param>
        /// <param name="msg">The MSG.</param>
        /// <remarks>
        /// The behaviour of this method is defined by the
        /// implementation. It may simply record the error message, or
        /// it may throw an exception.
        /// </remarks>
        public virtual void handleWarning(Source source, int line, int column, String msg)
        {
            warnings++;
        }

        /// <summary>
        /// Handles an error.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="line">The line.</param>
        /// <param name="column">The column.</param>
        /// <param name="msg">The MSG.</param>
        /// <remarks>
        /// The behaviour of this method is defined by the
        /// implementation. It may simply record the error message, or
        /// it may throw an exception.
        /// </remarks>
        public virtual void handleError(Source source, int line, int column, String msg)
        {
            errors++;
        }

        public virtual void handleSourceChange(Source source, String ev) {
        }
    }
}
