using System;
using TensionDev.CoordinateSystems;
using TensionDev.Maritime.Navigation;
using Xunit;

namespace TensionDev.Maritime.Navigation.Tests
{
    public class ClosestPointOfApproachTests : IDisposable
    {
        private bool disposedValue;

        internal const Int32 DISTANCE_PRECISION = 2;
        internal const Int32 TIME_PRECISION = 0;
        internal const Int32 METRE_TO_NAUTICALMILES = 1852;

        [Theory]
        [ClassData(typeof(ClosestPointOfApproachData))]
        public void TestCalculateCPAandTCPA(VesselTrack ownVessel, VesselTrack targetVessel, double lowCPA, double highCPA, double lowTCPA, double highTCPA)
        {
            ClosestPointOfApproach.CalculateCPAandTCPA(ownVessel, targetVessel, out double actualCPA, out double actualTCPA);
            actualCPA /= METRE_TO_NAUTICALMILES;

            Assert.InRange(actualCPA, lowCPA, highCPA);
            Assert.InRange(actualTCPA, lowTCPA, highTCPA);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitTestClosestPointOfApproach()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
