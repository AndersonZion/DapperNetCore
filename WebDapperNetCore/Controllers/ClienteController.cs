using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebDapperNetCore.Controllers
{
    [Authorize]
    public class ClienteController : Controller
    {
        public readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        // GET: ClienteController
        public ActionResult Index()
        {
            var result = _clienteService.GetAsnyClientes();
           return View(result);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            var result = _clienteService.GetAsnyCliente(id);
            return View(result);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("IdCliente,Nome")] Cliente cliente)
        {
            try
            {
                var result = _clienteService.InsertAsnyCliente(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _clienteService.GetAsnyCliente(id);
            return View(result);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                _clienteService.UpdateAsnyCliente(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _clienteService.GetAsnyCliente(id);
            return View(result);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var resultCliente = _clienteService.GetAsnyCliente(id);

                bool result =  _clienteService.DeleteAsnyCliente(resultCliente.IdCliente);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
