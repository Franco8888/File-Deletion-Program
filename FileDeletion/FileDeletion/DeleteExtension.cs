using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileDeletion
{
    public class DeleteExtension
    {
        public string Path { get; private set; }

        public List<string> Extensions { get; private set; }

        public DeleteExtension(string folderpath, List<string> ex )
        {
            Path = folderpath;
            Extensions = ex;
        }

        public void DeleteFiles()
        {
            List<FileInfo> list = new List<FileInfo>();
            foreach (string ext in Extensions)
                list.AddRange(new DirectoryInfo(Path).GetFiles("*" + ext, SearchOption.AllDirectories).Where(p =>
                      p.Extension.Equals(ext, StringComparison.CurrentCultureIgnoreCase))
                      .ToArray());

            foreach (var file in list)
            {
                File.Delete(file.FullName);
            }
        }

    }
}
