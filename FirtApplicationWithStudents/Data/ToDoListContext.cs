using FirtApplicationWithStudents.Models;
using Microsoft.EntityFrameworkCore;

namespace FirtApplicationWithStudents.Data
{
    public class ToDoListContext:DbContext
    {
        public ToDoListContext(DbContextOptions<ToDoListContext> options):base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
