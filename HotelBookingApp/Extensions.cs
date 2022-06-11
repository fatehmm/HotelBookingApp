using System;
namespace HotelBookingApp
{
	public static class Extensions
	{
		public static Room[] RoomAdd(this Room[] rooms, Room room)
        {
			Array.Resize(ref rooms, rooms.Length + 1);
			rooms[rooms.Length - 1] = room;
			return rooms;
        }
	}
}

