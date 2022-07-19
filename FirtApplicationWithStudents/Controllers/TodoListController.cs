using FirtApplicationWithStudents.Data;
using FirtApplicationWithStudents.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FirtApplicationWithStudents.Controllers
{
    [Route("api/")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private ToDoListContext _context;
        public TodoListController(ToDoListContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetNotes()
        {
            var notes = _context.Notes;
            return Ok(notes);
        }
        [HttpPost]
        public IActionResult PostNotes([FromBody] Note notes)
        {
            _context.Add(notes);
            _context.SaveChanges();
            return Created("", notes);
        }
        [HttpGet("{id}")]
        public IActionResult GetNoteId(int id)
        {
            var note = _context.Notes.Where(x => x.Id == id).FirstOrDefault();
            if (note is null)
                return NotFound("Afsus xatolik yuz berdi");

            return Ok(note);
        }
        [HttpDelete("{id}")]
        public IActionResult GetNoteDelete(int id)
        {
            var note = _context.Notes.Where(x => x.Id == id).FirstOrDefault();
            if (note is null)
                return NotFound("Afsus xatolik yuz berdi");
            _context.Remove(note);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult GetNoteUpdate(int id)
        {
            var note = _context.Notes.Where(x => x.Id == id).FirstOrDefault();
            _context.Update(note);

            _context.SaveChanges();
            return Ok(note);
        }
    }
}
