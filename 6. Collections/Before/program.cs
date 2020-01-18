using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP._6._Collections.Before
{
    public class Program
    {
        public void Main()
        {
            var filestore = new FileStore();
            var files = filestore.GetFiles();

            var myFiles = files
                .Where(f => f.Modified < DateTime.Now.Date && f.Size > 500000)
                .Where(f => f.Extension == "txt")
                .ToList();
        }
    }
}
