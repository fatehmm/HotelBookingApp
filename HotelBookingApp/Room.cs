using System;
namespace HotelBookingApp
{
	public class Room: Hotel
	{
		public Room()
		{
			RoomCounter++;
			_roomCode = RoomCounter;
		}
		public bool isWifi;

		public bool isRoomService;

		private static int RoomCounter = 0;

		private int _roomCode;

		public int RoomCode
        {
            get
            {
				return _roomCode;
            }
        }

		public bool isAvailable;

		public string Name;
	}
}

