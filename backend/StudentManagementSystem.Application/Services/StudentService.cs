using StudentManagementSystem.Application.DTOs;
using StudentManagementSystem.Application.Interfaces;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<StudentDto>> GetAllStudentsAsync()
    {
        var students = await _repository.GetAllAsync();

        return students.Select(x => new StudentDto
        {
            Id = x.Id,
            Name = x.Name,
            Email = x.Email,
            Age = x.Age,
            Course = x.Course
        }).ToList();
    }

    public async Task<StudentDto> AddStudentAsync(CreateStudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            Email = dto.Email,
            Age = dto.Age,
            Course = dto.Course
        };

        await _repository.AddAsync(student);

        return new StudentDto
        {
            Id = student.Id,
            Name = student.Name,
            Email = student.Email,
            Age = student.Age,
            Course = student.Course
        };
    }

    public async Task<StudentDto> UpdateStudentAsync(int id, UpdateStudentDto dto)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null)
            throw new Exception("Student not found");

        student.Name = dto.Name;
        student.Email = dto.Email;
        student.Age = dto.Age;
        student.Course = dto.Course;

        await _repository.UpdateAsync(student);

        return new StudentDto
        {
            Id = student.Id,
            Name = student.Name,
            Email = student.Email,
            Age = student.Age,
            Course = student.Course
        };
    }

    public async Task<bool> DeleteStudentAsync(int id)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null)
            return false;

        await _repository.DeleteAsync(student);

        return true;
    }
}