using CameraBazar.Data;
using CameraBazar.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CameraBazar.Services.Implementations
{
    public class CameraService : ICameraService
    {
        private readonly CameraBazarDbContext db;

        public CameraService(CameraBazarDbContext db)
        {
            this.db = db;
        }

        public void Create(
            CameraMakeType make,
            string model,
            decimal price,
            int quantity,
            int minShutterSpeed,
            int maxShutterSpeed,
            MinISO minISO,
            int maxISO,
            bool isFullFrame,
            string videoResolution,
            IEnumerable<LightMetering> lightMeterings,
            string description,
            string imageUrl,
            string userId)
        {
            /*
            LightMetering lightMetering = lightMeterings.First();
            foreach (var lightMeteringValue in lightMeterings.Skip(1))
            {
                lightMetering |= lightMeteringValue;
            }
            */

            var camera = new Camera()
            {
                Make = make,
                Model = model,
                Price = price,
                Quantity = quantity,
                MinShutterSpeed = minShutterSpeed,
                MaxShutterSpeed = maxShutterSpeed,
                MinISO = minISO,
                MaxISO = maxISO,
                IsFullFrame = isFullFrame,
                VideoResolution = videoResolution,
                LightMetering = (LightMetering)lightMeterings.Cast<int>().Sum(),
                Description = description,
                ImageUrl = imageUrl,
                UserId = userId
            };

            this.db.Add(camera);
            this.db.SaveChanges();
        }
    }
}
