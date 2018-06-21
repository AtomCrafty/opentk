//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES30
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "ParallelShaderCompile" in the extension "Khr".
        /// </summary>
        public static partial class Khr
        {
            /// <summary>
            /// [requires: KHR_parallel_shader_compile]
            /// </summary>
            /// <param name="count">
            /// </param>
            [AutoGenerated(Category = "KHR_parallel_shader_compile", Version = "", EntryPoint = "glMaxShaderCompilerThreadsKHR")]
            public static void MaxShaderCompilerThreads(uint count)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(451)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMaxShaderCompilerThreadsKHR(uint count);
        }
    }
}