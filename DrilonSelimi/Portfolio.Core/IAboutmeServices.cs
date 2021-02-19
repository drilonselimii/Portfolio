using Databaza.DB;
using System.Collections.Generic;

namespace Portfolio.Core
{
    public interface IAboutmeServices
    {
        Aboutme GetAboutme(int id);       
        void EditAboutme(Aboutme aboutme);
    }
}
