using System;
using System.Collections.Generic;

namespace OOP._6._Collections.After
{
    internal class FileStore
    {
        public FileStore()
        {
        }

        internal Files GetFiles()
        {
            return new Files(new List<FileInformation>());
        }
    }
}