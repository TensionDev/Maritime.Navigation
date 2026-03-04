using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TensionDev.CoordinateSystems;
using Xunit;

namespace TensionDev.Maritime.Navigation.Tests
{
    public class ClosestPointOfApproachData : TheoryData<VesselTrack, VesselTrack, Double, Double, Double, Double>
    {
        public ClosestPointOfApproachData()
        {
            Add(new VesselTrack(), new VesselTrack(), 0, 0, 0, 0);

            Add(new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02203,
                    LongitudeDecimalRadians = 1.81450,
                },
                SpeedOverGroundKnots = 1.98048,
                CourseOverGroundDegrees = 213.94921,
            }, new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02239,
                    LongitudeDecimalRadians = 1.81455,
                },
                SpeedOverGroundKnots = 5.37353,
                CourseOverGroundDegrees = 129.32617,
            }, 1.22, 1.24, 149, 151);

            Add(new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02203,
                    LongitudeDecimalRadians = 1.81450,
                },
                SpeedOverGroundKnots = 1.98048,
                CourseOverGroundDegrees = 213.94921,
            },
            new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02203,
                    LongitudeDecimalRadians = 1.81446,
                },
                SpeedOverGroundKnots = 1.99922,
                CourseOverGroundDegrees = 111.37690,
            }, 0.04, 0.06, 152, 154);

            Add(new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02203,
                    LongitudeDecimalRadians = 1.81450,
                },
                SpeedOverGroundKnots = 1.98048,
                CourseOverGroundDegrees = 213.94921,
            }, new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02202,
                    LongitudeDecimalRadians = 1.81422,
                },
                SpeedOverGroundKnots = 10.00002,
                CourseOverGroundDegrees = 90.80503,
            }, 0.09, 0.11, 308, 310);

            Add(new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02196,
                    LongitudeDecimalRadians = 1.81446,
                },
                SpeedOverGroundKnots = 1.04226,
                CourseOverGroundDegrees = 212.72825,
            }, new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02212,
                    LongitudeDecimalRadians = 1.81454,
                },
                SpeedOverGroundKnots = 6.00000,
                CourseOverGroundDegrees = 209.16741,
            }, 0.01, 0.03, 446, 448);

            Add(new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02196,
                    LongitudeDecimalRadians = 1.81446,
                },
                SpeedOverGroundKnots = 1.04226,
                CourseOverGroundDegrees = 212.72825,
            },
            new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02190,
                    LongitudeDecimalRadians = 1.81424,
                },
                SpeedOverGroundKnots = 6.08546,
                CourseOverGroundDegrees = 358.84242,
            }, 0.73, 0.75, 129, 131);

            Add(new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02196,
                    LongitudeDecimalRadians = 1.81446,
                },
                SpeedOverGroundKnots = 1.04226,
                CourseOverGroundDegrees = 180,
            },
            new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02190,
                    LongitudeDecimalRadians = 1.81424,
                },
                SpeedOverGroundKnots = 1.04226,
                CourseOverGroundDegrees = 180,
            }, 0.78, 0.79, -1, 1);

            Add(new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02196,
                    LongitudeDecimalRadians = 1.81446,
                },
                SpeedOverGroundKnots = 1.04226,
                CourseOverGroundDegrees = 270,
            },
            new VesselTrack()
            {
                VesselCoordinates = new GeographicCoordinateSystem()
                {
                    LatitudeDecimalRadians = 0.02190,
                    LongitudeDecimalRadians = 1.81424,
                },
                SpeedOverGroundKnots = 1.04226,
                CourseOverGroundDegrees = 270,
            }, 0.78, 0.79, -1, 1);
        }
    }
}
