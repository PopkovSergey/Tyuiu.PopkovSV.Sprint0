﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PopkovSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //Область создания методов тестирования, методов из библиотеки
            var name = "Сергей";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Сергей", res);
        }
    }
}
