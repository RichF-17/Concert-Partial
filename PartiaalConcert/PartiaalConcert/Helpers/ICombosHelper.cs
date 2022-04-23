using Microsoft.AspNetCore.Mvc.Rendering;

namespace PartiaalConcert.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();
    }
}
