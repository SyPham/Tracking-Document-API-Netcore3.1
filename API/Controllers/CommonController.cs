using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public interface ICommonController<T,K>
    {
        Task<IActionResult> GetAll();
        [HttpGet("{keyword}/{page}/{pageSize}")]
        Task<IActionResult> GetAll(string keyword, int page, int pageSize);
        [HttpPost]
        Task<IActionResult> Create(T userAccount);
        [HttpPost]
        Task<IActionResult> Edit(T userAccount);
        [HttpPost]
        Task<IActionResult> Remove(K id);
        [HttpGet("{id}")]
        Task<IActionResult> GetById(K id)
    }
}
