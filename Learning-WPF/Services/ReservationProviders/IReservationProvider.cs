using Learning_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_WPF.Services.ReservationProviders
{
    public interface IReservationProvider
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
    }
}
