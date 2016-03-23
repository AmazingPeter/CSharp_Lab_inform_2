using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem4_2
{
    //++Вариант 12. Состояние, Dependency Injection
    //Вы создаете текстовый редактор, который может находится в трех состояниях:
    //только для чтения,
    //режим редактирования,
    //режим только для чтения всех, кроме администратора (из этого режима можно перейти
    //в другой только введя пароль администратора, не нужно привязываться к реальному администратору,
    //можно выбрать произвольный пароль). Через Dependency Injection можно указать начальное состояние.

    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor(ModeFactory.CreateDefaultMode());
            editor.IncreasePrivilegies();
            editor.IncreasePrivilegies();
            editor.DecreasePrivilegies();
            editor.DecreasePrivilegies();

            Console.Read();
        }
    }
}
