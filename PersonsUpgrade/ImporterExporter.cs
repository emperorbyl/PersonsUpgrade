﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUpgrade
{
    public abstract class ImporterExporter
    {
        public string name { get; set; }
        public string description { get; set; }
        public abstract void Read(List<Person> context, string filename);
        public abstract void Write(List<MatchPair> context, string filename = null);
        protected string AppendExtension(string filename, string extension)
        {
            if (string.IsNullOrWhiteSpace(extension))
                extension = string.Empty;

            if (string.IsNullOrWhiteSpace(filename))
                filename = string.Empty;

            if (!extension.StartsWith("."))
                extension = "." + extension;

            if (!filename.EndsWith(extension))
                filename += extension;

            return filename;
        }
    }
}
