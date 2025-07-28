using Learning_WPF.Exceptions;
using Learning_WPF.Services.ReservationConflictValidators;
using Learning_WPF.Services.ReservationProviders;
using Learning_WPF.Services.ReservationsCreators;

namespace Learning_WPF.Models
{
    public class ReservationBook
    {
        private readonly IReservationProvider _reservationProvider;
        private readonly IReservationCreator _reservationCreator;
        private readonly IReservationConflictValidator _reservationConflictValidator;

        public ReservationBook(IReservationProvider reservationProvider, IReservationCreator reservationCreator, 
            IReservationConflictValidator reservationConflictValidator)
        {
            _reservationProvider = reservationProvider;
            _reservationCreator = reservationCreator;
            _reservationConflictValidator = reservationConflictValidator;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            return await _reservationProvider.GetAllReservations();
        }

        public async Task AddReservation(Reservation reservation)
        {
            Reservation conflictReservation = await _reservationConflictValidator.GetConflictReservation(reservation);

            if(conflictReservation != null)
            {
                throw new ReservationConflictException(conflictReservation, reservation);
            }

            await _reservationCreator.CreateReservation(reservation);
        }
    }
}
