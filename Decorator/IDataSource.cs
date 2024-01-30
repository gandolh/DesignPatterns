﻿using Microsoft.VisualBasic;

namespace DesignPatterns.Decorator
{
    internal interface IDataSource
    {
        public void WriteData(string data);
        public string ReadData();
    }
}
