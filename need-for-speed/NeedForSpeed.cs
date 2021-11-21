using System;

class RemoteControlCar
{

    private int speed;

    private int battery = 100;

    private int batteryDrain;

    private int distance = 0;

    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain ? true : false;        
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distance += speed;
            battery -= batteryDrain;
        }        
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{

    private int distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool CarCanFinish(RemoteControlCar car)
    {
        while (car.DistanceDriven() < distance && !car.BatteryDrained())
        {
            car.Drive();
        }

        return car.DistanceDriven() < distance ? false : true;
    }
}
