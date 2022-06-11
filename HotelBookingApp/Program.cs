using System;

namespace HotelBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = -1;
            Room[] cbRooms = new Room[0];
            Hotel CasaBlanca = new Hotel()
            {
                roomList = cbRooms
            };

            Room room1 = new Room()
            {
                Name = "Usaq otagi",
                isRoomService = true,
                isWifi = true,
                isAvailable = true

            };

            Room room2 = new Room()
            {
                Name = "Boyuk otagi",
                isRoomService = false,
                isWifi = true,
                isAvailable = true
            };


            Room room3 = new Room()
            {
                Name = "Qoca otagi",
                isRoomService = false,
                isWifi = false,
                isAvailable = true
            };

            Room room4 = new Room()
            {
                Name = "Turist otagi",
                isRoomService = true,
                isWifi = true,
                isAvailable = true
            };

            Room room5 = new Room()
            {
                Name = "VIP otaq",
                isRoomService = true,
                isWifi = false,
                isAvailable = true
            };

            Room room6 = new Room()
            {
                Name = "Qaqas otagi",
                isRoomService = false,
                isWifi = false,
                isAvailable = true
            };

            //Burani nece daha az kodla yaza bilerem bilmedim

            cbRooms = cbRooms.RoomAdd(room1);
            cbRooms = cbRooms.RoomAdd(room2);
            cbRooms = cbRooms.RoomAdd(room3);
            cbRooms = cbRooms.RoomAdd(room4);
            cbRooms = cbRooms.RoomAdd(room5);
            cbRooms = cbRooms.RoomAdd(room6);

            do
            {
                Console.WriteLine("CasaBlanca hotele xos gelmisiniz, secmek istediyiniz otagi secin...");
                Console.Write("Filterlemek isteyirsinizmi? (he/yox)..");
                string filterAnswer = "";

                string filterQuery;
                do
                {
                    filterQuery = Console.ReadLine().ToUpper();

                } while ((filterQuery != "HE" && filterQuery != "YOX") || filterQuery == null);
                

                if (filterQuery == "HE")
                {
                    Console.WriteLine("Neye gore filtrelemek isteyirsiniz?");
                    Console.WriteLine("1. Otaqda wifi olsun.");
                    Console.WriteLine("2. Otaqda room service olsun.");
                    do
                    {
                        filterAnswer = Console.ReadLine();

                    } while ((filterAnswer != "1" && filterAnswer != "2") || filterAnswer == null);

                    if (filterAnswer == "1")
                    {
                        foreach (var item in cbRooms)
                        {
                            if (item.isWifi == true)
                            {
                                Console.Write($"{item.RoomCode}. Otaq: {item.Name}");
                                if (item.isRoomService)
                                {
                                    Console.Write(" , Otaga servis: var. \n ");
                                }
                                else
                                {
                                    Console.Write(" , Otaga servis: yoxdu. \n ");
                                }
                            }
                        }
                        Console.WriteLine("0. Menudan cix");
                    }
                    else if (filterAnswer == "2")
                    {
                        foreach (var item in cbRooms)
                        {
                            if (item.isRoomService == true)
                            {
                                Console.Write($"{item.RoomCode}. Otaq: {item.Name}");
                                if (item.isWifi)
                                {
                                    Console.Write(" , Otaqda wifi: var. \n ");
                                }
                                else
                                {
                                    Console.Write(" , Otaqda wifi: yoxdu. \n ");
                                }
                            }
                        }
                        Console.WriteLine("0. Menudan cix");
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    foreach (var item in cbRooms)
                    {
                        if (item.isAvailable)
                        {
                            Console.Write($"{item.RoomCode}. Otaq: {item.Name}");
                            if (item.isRoomService)
                            {
                                Console.Write(" , Otaga servis: var, ");
                            }
                            else
                            {
                                Console.Write(" , Otaga servis: yoxdu, ");
                            }
                            if (item.isWifi)
                            {
                                Console.Write(" Wifi: var.\n");
                            }
                            else
                            {
                                Console.Write(" Wifi: yoxdu.\n");
                            }
                        }
                    }
                    Console.WriteLine("0. Menudan cix");
                }
                
                

                answer = int.Parse(Console.ReadLine());

                for (int i = 0; i < cbRooms.Length; i++)
                {
                    if (answer == 0)
                    {
                        break;
                    }
                    if (answer == cbRooms[i].RoomCode)
                    {
                        cbRooms[i].isAvailable = false;
                        Console.WriteLine("Otaginiz rezerv olundu!");
                        break;
                    }

                }
            } while (answer != 0);

            
        }
    }
}

