﻿using System;

namespace RefactoringGuru.AbstractFactory.Example.Buttons
{
    /**
     * EN: All products families have the same varieties (MacOS/Windows).
     * 
     * This is another variant of a button.
     * 
     * RU: Все семейства продуктов имеют одни и те же вариации (MacOS/Windows).
     * 
     * Это вариант кнопки под Windows.
     */
    class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("You have created WindowsButton.");
        }
    }
}
