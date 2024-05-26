using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirthdayWPFApplication.MainWindow;

namespace PresentCreditsApplication
{
    public class TextReader
    {
        public IReadAble Text { get; set; }
        public TextReader(IReadAble text)
        {
            Text = text;
        }
        public string Read(List<string> textchunks)
        {
            var rows = new List<string>();
            foreach (var chunk in textchunks)
            {
                foreach (var row in ReadChunkToRows(chunk))
                {
                    rows.Add(row.Trim());
                }
            }
            rows.Reverse();
            return string.Join('\n', rows);
        }

        public IEnumerable<string> ReadChunkToRows(string textchunk)

        {
            //var chunkToRows = new List<string>();

            foreach (string row in Text.NextRow(textchunk))
            {
                yield return row;
            }
        }
    }

}

