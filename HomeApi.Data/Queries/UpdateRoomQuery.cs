namespace HomeApi.Data.Queries
{
    public class UpdateRoomQuery
    {
        public UpdateRoomQuery(
            int newArea = 0,
            bool newGasConnected = false,
            int newVoltage = 0)
        {
            NewArea = newArea;
            NewGasConnected = newGasConnected;
            NewVoltage = newVoltage;
        }

        public int NewArea { get; }

        public bool NewGasConnected { get; }

        public int NewVoltage { get; }
    }
}
