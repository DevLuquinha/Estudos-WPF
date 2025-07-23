using Learning_WPF.DbContexts;
using Learning_WPF.DTOs;
using Learning_WPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_WPF.Services.ReservationProviders
{
    internal class DatabaseReservationProvider : IReservationProvider
    {
        private readonly ReservoomDbContextFactory _dbContextFactory;

        public DatabaseReservationProvider(ReservoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            using (ReservoomDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ReservationDTO> reservationsDTOs = await context.Reservations.ToListAsync();

                return reservationsDTOs.Select(r => ToReservation(r));
            }
        }

        private static Reservation ToReservation(ReservationDTO r)
        {
            return new Reservation(new RoomID(r.FloorNumber, r.RoomNumber), r.UserName, r.StartDate, r.EndDate);
        }
    }
}
