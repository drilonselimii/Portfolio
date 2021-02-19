using Databaza.DB;
using System.Collections.Generic;

namespace Portfolio.Core
{
    public interface IAdminsServices
    {
        Admin CreateAdmin(Admin admin);

        Admin GetAdmin(int id);
        List<Admin> GetAdmins();

        void DeleteAdmin(int id);
        void EditAdmin(Admin admin);
    }
}
