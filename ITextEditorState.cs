using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_2
{
    interface ITextEditorState
    {
        void IncreasePrivilegies(TextEditor editor);
        void DecreasePrivilegies(TextEditor editor);
    }
}
