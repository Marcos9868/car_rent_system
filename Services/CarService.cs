using car_rent_system.Contracts;
using car_rent_system.Data;
using car_rent_system.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace car_rent_system.Services
{
    public class CarService : ICarService
    {
        private readonly DataContext _context;
        private readonly UserService _userService;
        public CarService(DataContext context, UserService userService)
        {
            _context = context;
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<Car>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        [HttpGet]
        public async Task<Car> GetCar(int CarId)
        {
            return await _context.Cars.FindAsync(CarId);
        }

        [HttpPost]
        public async Task<Car> RegistrateCar(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return car;
        }

        [HttpGet]
        public async Task<Car> GetCarByClient(int Client_Id)
        {
            var car = await _context.Cars.FindAsync(Client_Id);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            return car;
        }
    }
}