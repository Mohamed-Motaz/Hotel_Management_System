
using Backend;

public class RoomAndBoarding
{

    public string roomType { get; set; }
    public string boardingType { get; set; }


    public RoomAndBoarding(string roomType, string boardingType)
    {
        this.roomType = roomType;
        this.boardingType = boardingType;
    }

    public RoomAndBoarding()
    {
    }
}