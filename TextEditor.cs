using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_2
{
    class TextEditor
    {
        public ITextEditorState State { get; set; }

        public TextEditor(ITextEditorState s)
        {
            State = s;
        }

        public void IncreasePrivilegies()
        {
            State.IncreasePrivilegies(this);
        }
        public void DecreasePrivilegies()
        {
            State.DecreasePrivilegies(this);
        }
    }
}
