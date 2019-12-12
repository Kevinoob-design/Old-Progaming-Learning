using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Information about a directory item such as a drive, a file, or a folder.

namespace WpfTreeView.DIrectory.Data
{
    public class DirectoryItem
    {
        //The type of this item.

        public DirectoryItemType Type { get; set; }

        //The absolute path to this item.

        public string FullPath { get; set; }

        // The name of this directory item.

        public string Name { get {
            return this.Type == DirectoryItemType.Drive ?
            this.FullPath : DirectoryStructure.GetFileFolderName(this.FullPath); } }
    }
}
