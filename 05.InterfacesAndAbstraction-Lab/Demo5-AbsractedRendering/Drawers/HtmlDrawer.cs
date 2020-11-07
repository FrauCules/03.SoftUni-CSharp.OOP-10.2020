using Demo5_AbsractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Demo5_AbsractedRendering.Drawers
{
    class HtmlDrawer : IDrawer
    {
        private string path;
        private StringBuilder result;
        public HtmlDrawer(string path)
        {
            this.path = path;
            result = new StringBuilder();
        }
        public void Write(string input)
        {
            using (StreamWriter writer = new StreamWriter(path + ".html", false))
            {
                result.Append(input);
                writer.Write($"<html><head></head><body><h1>Best game!!!</h1><p>{result.ToString()}</p></body></html>");
            }
        }

        public void WriteLine(string input)
        {
            using (StreamWriter writer = new StreamWriter(path + ".html", false))
            {
                result.Append(input);
                writer.WriteLine($"<html><head></head><body><h1>Best game!!!</h1><p>{result.ToString()}</p></body></html>");
            }
        }
    }
}
