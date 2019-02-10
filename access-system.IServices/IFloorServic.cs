using access_system.Entities;
using access_system.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.IServices
{
    public interface IFloorServic
    {
        FloorEntity Floor { get; set; }

        void AddRoomDescription(int roomNumber, RoomTypes roomType, string roomName);

        void AddUserWithUniqAccessForRoom(int userId, int roomNumber);

        void AddAccesModifierForRoom(UserTypes type, int roomNumber);

        LogEntryEntity EmulateEntranceToRoom(UserEntity user, int roomNumber);
    }
}
