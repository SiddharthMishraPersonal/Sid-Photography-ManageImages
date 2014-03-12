using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sid.Photography.ManageImages;

namespace Sid.Photography.RunApp
{
  class Program
  {
    static void Main(string[] args)
    {
      foreach (var s in Utilities.GetFilelList(args[0], args[1]))
      {
        Console.WriteLine(s.FullName);
      }

      foreach (var s in Utilities.GetFilelList(args[0], args[2]))
      {
        Console.WriteLine(s.FullName);
      }
      Console.ReadKey();
    }
  }
}
