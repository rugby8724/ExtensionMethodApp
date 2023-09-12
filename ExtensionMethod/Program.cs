using ExtensionMethod;

"Hello World".PrintToConsole();

HotelRoomModel room = new HotelRoomModel();

room.TurnOnAir().SetTemperature(68).OpenShades();

Console.ReadLine();
