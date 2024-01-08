namespace StudentManagementAPI.Models;

public class Student {
    public int Id { get; set; }
    public string? Dni { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Address { get; set; }
    public string? Cp { get; set; }
    public string? City { get; set; }
    public string? Phone  { get; set; } // Se usa string en vez de int para el manejo de memoria
    public string? Email { get; set; }

}