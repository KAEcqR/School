using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swieta2024.Models
{
    public interface IRepository
    {
        List<Danie> GetDanie();
        Danie? GetDanieById(int id);
    }
}
