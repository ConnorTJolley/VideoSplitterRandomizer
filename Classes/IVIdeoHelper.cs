using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRandomizer.Classes
{
    public interface IVIdeoHelper
    {
        string Directory { get; set; }

        void SetDirectory(string directory);

        void ClearDirectory();
    }
}
