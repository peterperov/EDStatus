using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDStatus_v2
{


    /*
     * 
     * https://stackoverflow.com/questions/19582477/combining-enum-values-with-bit-flags
     * 
     */

    /*

https://elite-journal.readthedocs.io/en/latest/Status%20File/

2	4	0000 0004	Landing Gear Down
3	8	0000 0008	Shields Up
4	16	0000 0010	Supercruise
5	32	0000 0020	FlightAssist Off
6	64	0000 0040	Hardpoints Deployed
8	256	0000 0100	LightsOn
9	512	0000 0200	Cargo Scoop Deployed
12	4096	0000 1000	Srv Handbrake
15	32768	0000 8000	Srv DriveAssist
28	268435456	1000 0000	Night Vision
31	2147483648	8000 0000	srvHighBeam 


    ucFlightAssist
    ucLights
    ucCargoScoop
    ucNightVision

 * */




    [Flags]
    public enum FlagValues : uint
    {
        Docked = 1,
        Landed = 2,
        LandingGearDown = 4,
        ShieldsUp = 8,
        Supercruise = 16,
        FlightAssistOff = 32,
        HardpointsDeployed = 64,
        LightsOn = 256,
        CargoScoopDeployed = 512,
        SilentRunning = 1024,
        ScoopingFuel = 2048,
        SrvHandbrake = 4096,
        SrvDriveAssist = 32768,
        FsdMassLocked = 65536,
        FsdCharging = 131072,
        FsdCooldown = 262144,
        OverHeating = 1048576,
        IsInDanger = 4194304,
        BeingInterdicted = 8388608,
        InMainShip = 16777216, 
        InFighter = 33554432, 
        InSRV = 67108864,
        AnalysisMode = 134217728,
        NightVision = 268435456,
        FsdJump = 1073741824,
        srvHighBeam = 2147483648
    }


    public class FlagValue
    {
        string _value = "";
        uint _number = 0; 
        public FlagValue(string value)
        {
            _value = value;

            if ( !UInt32.TryParse(_value, out _number) )
            {
                _number = 0; 
            }

        }

        public uint Value { get { return _number; } }


        public bool LandingGearDown() { return (_number & (uint) FlagValues.LandingGearDown) == (uint) FlagValues.LandingGearDown; }
        public bool ShieldsUp() { return (_number & (uint)FlagValues.ShieldsUp) == (uint)FlagValues.ShieldsUp; }
        public bool Supercruise() { return (_number & (uint)FlagValues.Supercruise) == (uint)FlagValues.Supercruise; }
        public bool FlightAssistOff() { return (_number & (uint)FlagValues.FlightAssistOff) == (uint)FlagValues.FlightAssistOff; }
        public bool HardpointsDeployed() { return (_number & (uint)FlagValues.HardpointsDeployed) == (uint)FlagValues.HardpointsDeployed; }

        public bool LightsOn() { return (_number & (uint)FlagValues.LightsOn) == (uint)FlagValues.LightsOn; }

        public bool CargoScoopDeployed() { return (_number & (uint)FlagValues.CargoScoopDeployed) == (uint)FlagValues.CargoScoopDeployed; }
        public bool SrvHandbrake() { return (_number & (uint)FlagValues.SrvHandbrake) == (uint)FlagValues.SrvHandbrake; }

        public bool SrvDriveAssist() { return (_number & (uint)FlagValues.SrvDriveAssist) == (uint)FlagValues.SrvDriveAssist; }
        public bool NightVision() { return (_number & (uint)FlagValues.NightVision) == (uint)FlagValues.NightVision; }
        public bool srvHighBeam() { return (_number & (uint)FlagValues.srvHighBeam) == (uint)FlagValues.srvHighBeam; }

    }
}
