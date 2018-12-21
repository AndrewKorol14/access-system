﻿using access_system.Entities;
using access_system.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_system.Enums;

namespace Services
{
    class FloorServic : IFloorServic
    {
        public FloorEntity Floor {get; set;}
        public IRoomServic RoomServic { get; set; }

        public FloorServic(FloorEntity floor, IRoomServic roomServic)
        {
            Floor = floor;
            RoomServic = roomServic;
        }

        public FloorServic(IRoomServic roomServic)
        {
            RoomServic = roomServic;
        }

        public void AddAccesModifierForRoom(UserTypes type, int roomNumber)
        {
            RoomServic.Room = Floor.Rooms[roomNumber - 1];
            RoomServic.AddAccesModifierForRoom(type);
        }

        public void AddRoomDescription(int roomNumber, RoomTypes roomType, string roomName)
        {
            Floor.Rooms[roomNumber - 1].RoomType = roomType;
            Floor.Rooms[roomNumber - 1].RoomName = roomName;
        }

        public void AddUserWithUniqAccessForRoom(UserEntity user, int roomNumber)
        {
            RoomServic.Room = Floor.Rooms[roomNumber - 1];
            RoomServic.AddUserWithUniqAccessForRoom(user);
        }

        public LogEntryEntity EmulateEntranceToRoom(UserEntity user, int roomNumber)
        {
            RoomServic.Room = Floor.Rooms[roomNumber - 1];
            return RoomServic.LoginAttempt(user);
        }
    }
}
