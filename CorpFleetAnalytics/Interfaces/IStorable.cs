using System;
using System.Collections.Generic;
using System.Text;

namespace CorpFleetAnalytics.Interfaces
{
    public interface IStorable
    {
        string FilePath { get; set; }
        void Save();
    }
}
