using System.Collections.Generic;
using System.Text;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public interface IRestuarantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
