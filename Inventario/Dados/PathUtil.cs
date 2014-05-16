using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Coletor.Dados
{
    public static class PathUtil
    {
        public static string Combine(string path1, string path2)
        {
            if (path1.EndsWith("\\") && path2.StartsWith("\\"))
            {
                path1 = path1.TrimEnd('\\');
            }
            if (path1.EndsWith("/") && path2.StartsWith("/"))
            {
                path1 = path1.TrimEnd('/');
            }
            return string.Format("{0}{1}",path1,path2);
        }
    }
}
