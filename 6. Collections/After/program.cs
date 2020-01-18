using System;
using System.Linq;
using System.Text;
using OOP._6._Collections.Before;

namespace OOP._6._Collections.After
{
    public class Program
    {
        public void Main()
        {
            var filestore = new FileStore();
            var files = filestore.GetFiles();

            var myFiles = files
                .ModifiedEarlierThan(DateTime.Now)
                .SizeMoreThan(50000)
                .WichAreTextFiles()
                .ToList();
        }
    }
}
