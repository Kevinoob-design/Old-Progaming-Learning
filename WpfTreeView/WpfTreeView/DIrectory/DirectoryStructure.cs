using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTreeView.DIrectory.Data;

//A helper class to query information about directories.

namespace WpfTreeView.DIrectory
{
    public static class DirectoryStructure
    {
        //Gets all logical drives on the computer.

        public static List<DirectoryItem> GetLogicalDrives()
        {
            //Get every logical drive on the machine.
            return Directory.GetLogicalDrives().Select(drive => new DirectoryItem
            {
                FullPath = drive,
                Type = DirectoryItemType.Drive

            }).ToList();
        }

        ///Gets the directories top-level content
        ///<param name="fullPath">The full path to the content</param>

        public static List<DirectoryItem> GetDirectoryContents(string fullPath)
        {
            //Create the empty list.
            var items = new List<DirectoryItem>();

            #region Get Folders

            //Try and get directories from the folder
            //ignoring any issues doing so
            try
            {
                var dirs = Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                    items.AddRange(dirs.Select(dir => new DirectoryItem
                    {
                        FullPath = dir,
                        Type = DirectoryItemType.Folder
                    }));
            }
            catch { }

            #endregion

            #region Get Files

            //Try and get files from the folder
            //ignoring any issues doing so
            try
            {
                var fls = Directory.GetFiles(fullPath);

                if (fls.Length > 0)
                    items.AddRange(fls.Select(file => new DirectoryItem {
                        FullPath = file, 
                        Type = DirectoryItemType.Folder
                    }));
            }
            catch { }

            return items;

            #endregion
        }


        #region Helpers
        //Find the file or folder name from a full path.
        public static string GetFileFolderName(string path)
        {
            // C:\Something\a folder
            // C:\Something/a file.png
            // a file file.png

            if (string.IsNullOrEmpty(path))
                return string.Empty;

            //Make al slashes back slashes
            var normalizaPath = path.Replace('/', '\\');

            //Find the last backslash in the path.
            var lastIndex = normalizaPath.LastIndexOf('\\');

            //If we don't find a backslash, return the path it self
            if (lastIndex < 0)
                return path;

            //Return the name after the last back slash
            return path.Substring(lastIndex + 1);
        }
        #endregion
    }
}
