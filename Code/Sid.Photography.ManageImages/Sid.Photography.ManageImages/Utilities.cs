using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sid.Photography.ManageImages
{
  public class Utilities
  {
    public static List<FileInfo> GetFilelList(string location, string extension)
    {
      //Check whether directory exists
      if (!Directory.Exists(location))
        return null;

      //Get All files with jpg and jpeg extension
      var directory = new DirectoryInfo(location);
      var fileList = directory.GetFiles(string.Format("*.{0}", extension)).ToList();

      return fileList;
    }
  }
}
