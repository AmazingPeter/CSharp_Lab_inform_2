using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_2
{
    static class ModeFactory
    {
        public static ITextEditorState CreateDefaultMode()
        {
            return new ReadOnly();
        }
    }
}
