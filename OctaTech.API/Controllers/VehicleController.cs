using Microsoft.AspNetCore.Mvc;
using OctaTech.API.Model.Vehicle;
using OctaTech.Domain.Entity;
using OctaTech.Domain.Interface.Service;
using System.Collections.Generic;
using System.Net;

namespace OctaTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Vehicle>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var vehicles = _vehicleService.GetAll();
            if (vehicles == null)
                return NotFound();

            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Vehicle), (int)HttpStatusCode.OK)]
        public IActionResult GetById(int id)
        {
            var vehicle = _vehicleService.GetById(id);
            if (vehicle == null)
                return NotFound();

            return Ok(vehicle);
        }

        [HttpPost("Create")]
        public IActionResult AddVehicle(Vehicle vehicleModel)
        {
            if (vehicleModel == null)
                return BadRequest();

            _vehicleService.Add(vehicleModel);

            return Ok();
        }

        [HttpPut("{id}")]  
        public IActionResult UpdateVehicleByID(int id, [FromBody] VehicleRequest vehicleRequest)
        {
            if (vehicleRequest == null)
                return BadRequest();

            var vehicle = _vehicleService.GetById(id);
            if (vehicle == null)
                return NotFound();

            vehicle.Model = vehicleRequest.Model;
            vehicle.Plate = vehicleRequest.Plate;

            _vehicleService.Update(vehicle);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteVehicleByID(int id)
        {
            var vehicle = _vehicleService.GetById(id);
            if (vehicle == null)
                return NotFound();

            _vehicleService.Remove(vehicle);

            return Ok();
        }

        [HttpGet("Paginated")]
        public IActionResult GetPaginated([FromQuery] int page, [FromQuery] int pageSize, [FromQuery] bool orderBy)
        {
            var vehicles = _vehicleService.GetPaginated(pageSize, page, orderBy);
            if (vehicles == null)
                return NotFound();

            return Ok(vehicles);
        }
    }
}
