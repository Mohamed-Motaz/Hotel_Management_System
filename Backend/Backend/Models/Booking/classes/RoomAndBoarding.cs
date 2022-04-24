
using Backend;

public class RoomAndBoarding
{

    public RoomTypes roomType { get; set; }
    public BoardingTypes boardingType { get; set; }
    public dynamic RoomType { get; }
    public dynamic BoardingType { get; }

    public RoomAndBoarding(RoomTypes roomType, BoardingTypes boardingType)
    {
        this.roomType = roomType;
        this.boardingType = boardingType;
    }

    public RoomAndBoarding()
    {
    }
}