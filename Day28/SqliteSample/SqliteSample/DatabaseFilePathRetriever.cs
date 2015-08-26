using System;
using System.IO;

namespace SqliteSample
{
    public static class DatabaseFilePathRetriever
    {
        public static string GetPath()
        {
            const string filename = "TodoDB.db3";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);
            return path;
        }
    }
}

