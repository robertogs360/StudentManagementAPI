using Microsoft.EntityFrameworkCore;

namespace StudentManagementAPI.Models;

public class StudentContext : DbContext
{
    public StudentContext (DbContextOptions<StudentContext> options)
        : base(options)
    {
    }
    public DbSet<Student> Students { get; set; } = null!;
}