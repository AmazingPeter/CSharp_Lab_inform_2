using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_2
{
    class ReadOnly:ITextEditorState
    {
        public void IncreasePrivilegies(TextEditor editor)
        {
            Console.WriteLine("Введите пароль:");
            if (Console.ReadLine() != "")
            {
                Console.WriteLine("Привилегии увеличены ,теперь есть доступ для чтения и переход в другие режимы без пароля");
                editor.State = new ReadOnlyAll();
            }
            else
            {
                Console.WriteLine("Неверный пароль!");
            }
        }
        public void DecreasePrivilegies(TextEditor editor)
        {
            Console.WriteLine("Привилении остались без изменения,так как они достигли минимальных");
        }
    }
}
