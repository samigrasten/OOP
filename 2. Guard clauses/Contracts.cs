using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._2._Guard_clauses
{
    public static class Contracts
    {
        public static void Requires(Func<bool> expression, string error)
        {
            if (!expression()) throw new ArgumentException(error);
        }
    }
}
