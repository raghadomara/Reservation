namespace Reservation
{
    public class ReservationModel
    {
        private int numOfPeople;
        private string reservationDate;
        private string time;

        public ReservationModel(int numOfPeople, string reservationDate, string time)
        {
            this.numOfPeople = numOfPeople;
            this.reservationDate = reservationDate;
            this.time = time;
        }

        public ReservationModel()
        {
            numOfPeople = 0;
            reservationDate = "";
            time = "";
        }

        public void SetNumOfPeople(int num)
        {
            numOfPeople = num;
        }

        public int GetNumOfPeople()
        {
            return numOfPeople;
        }


        public void SetReservationDate(string date)
        {
            reservationDate = date;
        }

        public string GetReservationDate()
        {
            return reservationDate;
        }

        public void SetTime(string t)
        {
            time = t;
        }

        public string GetTime()
        {
            return time;
        }
    }
}
