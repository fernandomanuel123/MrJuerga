using MrJuerga.Entity;
using OfficeOpenXml;
using System.Collections.Generic;

namespace MrJuerga.Service
{
    public interface IUsuarioService : IService<Usuario>
    {
        IEnumerable<Usuario> FetchUsuariobyName(string name);
        byte[] GetExcel();
        Usuario Authenticate(string username, string password);
        Usuario Register(UsuarioDTO user);
        Usuario GetById(int id);
        Usuario updatejwt(UsuarioDTO user);
        Usuario updatepsw(UsuarioDTO user);
        bool loadUsers(string name);
        bool loadUsersExcel(string name);
        
    }
}