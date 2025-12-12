using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlInventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private InventoryController _inventoryController;

        public UserController(InventoryController inventoryController)
        {
            _inventoryController = inventoryController;
        }
    }
}
