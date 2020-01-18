using System;
using System.Collections.Generic;

namespace OOP._6._Collections.After
{
    public class Files
    {
        public Files(IEnumerable<FileInformation> files)
        {
            _files = files;
        }

        public Files ModifiedEarlierThan(DateTime date)
            => new Files(_files.Where(f => f.Modified < date.Date));

        public Files SizeMoreThan(long size)
            => new Files(_files.Where(f => f.Size > size));
        public Files WichAreTextFiles()
            => new Files(_files.Where(f => f.Extension == "txt"));

        public List<FileInformation> ToList() => _files.ToList();


        private IEnumerable<FileInformation> _files;
    }
}
