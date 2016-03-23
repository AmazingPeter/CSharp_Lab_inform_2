using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_2
{
    class ReadOnlyAll:ITextEditorState
    {
        public void IncreasePrivilegies(TextEditor editor)
        {
            Console.WriteLine("Привилегии увеличены,теперь есть доступ для редактирования и переход в другие режимы без пароля");
            editor.State = new EditAll();
        }
        public void DecreasePrivilegies(TextEditor editor)
        {
            Console.WriteLine("Привилении уменьшены,теперь есть доступ для чтения и переход в другие режимы только введя пароль");
            editor.State = new ReadOnly();
        }
    }
}
