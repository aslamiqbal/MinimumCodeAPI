using GenericAPI.V7;
using MinimumCodeAPI.Context;
using MinimumCodeAPI.Model;
using MinimumCodeAPI.V_Model;

namespace MinimumCodeAPI.Controllers
{
    [Tags("Public API")]
    public class CarTypeController : BaseAPI<BMCarType, VM_BMCarType, Minimum_CTX>
    {

    }

}
